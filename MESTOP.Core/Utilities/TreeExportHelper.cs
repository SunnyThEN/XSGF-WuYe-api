using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MESTOP.Core.Extensions;
using MESTOP.Entity.DomainModels;

namespace MESTOP.Core.Utilities
{
    /// <summary>
    /// 树形表格导出：按父子关系深度优先排序，并计算 Excel 层级。
    /// </summary>
    public static class TreeExportHelper
    {
        private static readonly string[] DefaultParentFieldNames = { "ParentId", "parentId", "Pid", "pid" };

        public static bool TryResolveTreeFields(
            Type entityType,
            out PropertyInfo keyProperty,
            out PropertyInfo parentProperty,
            string keyField = null,
            string parentField = null)
        {
            keyProperty = null;
            parentProperty = null;
            if (entityType == null) return false;

            var properties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (!string.IsNullOrWhiteSpace(parentField))
            {
                parentProperty = properties.FirstOrDefault(p =>
                    string.Equals(p.Name, parentField, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                parentProperty = properties.FirstOrDefault(p =>
                    DefaultParentFieldNames.Any(n => string.Equals(p.Name, n, StringComparison.OrdinalIgnoreCase)));
            }

            if (parentProperty == null) return false;

            if (!string.IsNullOrWhiteSpace(keyField))
            {
                keyProperty = properties.FirstOrDefault(p =>
                    string.Equals(p.Name, keyField, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                keyProperty = entityType.GetKeyProperty();
            }

            return keyProperty != null;
        }

        /// <summary>
        /// 将扁平列表按树形深度优先排序，并返回每行层级（根节点为 0）。
        /// </summary>
        public static List<T> OrderByTreeDepth<T>(
            List<T> list,
            PropertyInfo keyProperty,
            PropertyInfo parentProperty,
            out int[] levels)
        {
            levels = Array.Empty<int>();
            if (list == null || list.Count == 0) return list ?? new List<T>();

            var keyLookup = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
            var childrenMap = new Dictionary<string, List<T>>(StringComparer.OrdinalIgnoreCase);

            foreach (var item in list)
            {
                var key = NormalizeKey(keyProperty.GetValue(item));
                if (string.IsNullOrEmpty(key)) continue;
                keyLookup[key] = item;
            }

            foreach (var item in list)
            {
                var parentKey = NormalizeKey(parentProperty.GetValue(item));
                if (string.IsNullOrEmpty(parentKey) || IsRootParentValue(parentProperty.GetValue(item)))
                {
                    parentKey = "__ROOT__";
                }
                else if (!keyLookup.ContainsKey(parentKey))
                {
                    parentKey = "__ROOT__";
                }

                if (!childrenMap.TryGetValue(parentKey, out var children))
                {
                    children = new List<T>();
                    childrenMap[parentKey] = children;
                }
                children.Add(item);
            }

            var ordered = new List<T>(list.Count);
            var levelList = new List<int>(list.Count);
            var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            void Visit(T node, int depth)
            {
                var key = NormalizeKey(keyProperty.GetValue(node));
                if (!string.IsNullOrEmpty(key))
                {
                    if (!visited.Add(key)) return;
                }

                ordered.Add(node);
                levelList.Add(depth);

                if (string.IsNullOrEmpty(key) || !childrenMap.TryGetValue(key, out var children)) return;
                foreach (var child in children)
                {
                    Visit(child, depth + 1);
                }
            }

            if (childrenMap.TryGetValue("__ROOT__", out var roots))
            {
                foreach (var root in roots)
                {
                    Visit(root, 0);
                }
            }

            foreach (var item in list)
            {
                var key = NormalizeKey(keyProperty.GetValue(item));
                if (!string.IsNullOrEmpty(key) && visited.Contains(key)) continue;
                Visit(item, 0);
            }

            levels = levelList.ToArray();
            return ordered;
        }

        public static bool ShouldExportAsTree(
            Type entityType,
            PageDataOptions pageData,
            bool exportAsTree,
            bool exportAsFlat,
            string keyField,
            string parentField)
        {
            if (exportAsFlat) return false;
            if (pageData?.TreeExport == false) return false;
            if (!TryResolveTreeFields(entityType, out _, out _, keyField, parentField)) return false;
            if (pageData?.TreeExport == true || exportAsTree) return true;
            // 含父子字段时默认树形导出
            return true;
        }

        public static string ResolveIndentColumn(
            string[] exportColumns,
            string configuredColumn,
            PropertyInfo[] exportedProperties)
        {
            if (!string.IsNullOrWhiteSpace(configuredColumn)) return configuredColumn;

            if (exportColumns != null && exportColumns.Length > 0)
            {
                return exportColumns[0];
            }

            var nameColumn = exportedProperties?
                .Select(p => p.Name)
                .FirstOrDefault(n =>
                    n.EndsWith("Name", StringComparison.OrdinalIgnoreCase)
                    || n.EndsWith("Title", StringComparison.OrdinalIgnoreCase)
                    || n.Equals("TreeName", StringComparison.OrdinalIgnoreCase));

            return nameColumn ?? exportedProperties?.FirstOrDefault()?.Name;
        }

        private static string NormalizeKey(object value)
        {
            if (value == null) return null;
            return value.ToString()?.Trim();
        }

        private static bool IsRootParentValue(object parentValue)
        {
            if (parentValue == null) return true;
            switch (parentValue)
            {
                case int i:
                    return i == 0;
                case long l:
                    return l == 0;
                case Guid g:
                    return g == Guid.Empty;
                case string s:
                    return string.IsNullOrWhiteSpace(s);
                default:
                    return false;
            }
        }
    }
}
