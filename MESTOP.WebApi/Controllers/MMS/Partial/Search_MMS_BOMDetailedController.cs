/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Search_MMS_BOMDetailed",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using MMS.IServices;
using MESTOP.Core.Enums;
using MMS.Repositories;
using MESTOP.Core.Filters;
using System.Linq;
using MESTOP.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using StackExchange.Redis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using SkiaSharp;
using System.Reflection.Emit;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using MESTOP.Core.Const;
using System.Reflection;
using WOC.Repositories;

namespace MMS.Controllers
{
    public partial class Search_MMS_BOMDetailedController
    {
        private readonly ISearch_MMS_BOMDetailedService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Search_MMS_BOMDetailedController(
            ISearch_MMS_BOMDetailedService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return GetSearch_MMS_BOMDetailedRootData(loadData);
            //return GetTreeTableRootData(loadData).Result;

        }


        [HttpPost, Route("GetSearch_MMS_BOMDetailedRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetSearch_MMS_BOMDetailedRootData([FromBody] PageDataOptions options)
        {

            var query = Search_MMS_BOMDetailedRepository.Instance.FindAsIQueryable(x =>x.isDel!=1);
            options = options ?? new PageDataOptions();

            List<SearchParameters> searchParametersList = new List<SearchParameters>();
            if (!string.IsNullOrEmpty(options.Wheres))
            {
                try
                {
                    searchParametersList = options.Wheres.DeserializeObject<List<SearchParameters>>();
                }
                catch { }
            }
            if (searchParametersList.Count > 0)
            {
                for (int i = 0; i < searchParametersList.Count; i++)
            {
                SearchParameters x = searchParametersList[i];
                x.DisplayType = x.DisplayType.GetDBCondition();
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "MaterialCode")
                    {
                        query = query.Where(s => s.MaterialCode.Contains(x.Value));

                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "BOMCode")
                    {
                        query = query.Where(s => s.BOMCode.Contains(x.Value));

                    } 
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "MaterialName")
                    {
                        query = query.Where(s => s.MaterialName.Contains(x.Value));

                    }

                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "MaterialTypeCode")
                    {
                        query = query.Where(s => s.MaterialTypeCode==x.Value);

                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "IsMaterial")
                    {
                        query = query.Where(s => s.MaterialCode==x.Value);

                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "ParentId")
                    {
                        query = query.Where(s => s.ParentId.Contains(x.Value));

                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "VehicleTypeCode")
                    {
                        query = query.Where(s => s.VehicleTypeCode.Contains(x.Value));

                    }
                    if (!string.IsNullOrEmpty(x.Value) && x.Name == "ContainerTypeCode")
                    {
                        query = query.Where(s => s.ContainerTypeCode.Contains(x.Value));

                    }
                }
            }
            else
                {

                query = query.Where(x => x.ParentId == null ||x.ParentId=="");
                }
            var roleRepository = Search_MMS_BOMDetailedRepository.Instance.FindAsIQueryable(x => x.isDel!=1);

            //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置
     

            //var rows = GetBOMDetails(options.Wheres).AsEnumerable().TakeOrderByPage(options.Page, options.Rows).OrderBy(x => x.BOMCode).ToList();
            string fs = options.Wheres;
           


                var rows = query.TakeOrderByPage(options.Page, options.Rows)
                .OrderBy(x => x.BOMCode)
                .Select(s => new
                {
                    Id = s.BOMCode,
                    s.MaterialCode,
                    s.MaterialName,
                    s.BOMCode,
                    s.ParentId,
                    s.MaterialWorkTime,
                    s.MasterUOM,
                    s.MasterQTY,
                    s.ContainerTypeCode,
                    s.VehicleTypeCode,
                    s.IsMaterial,
                    s.isDel,
                    s.MaterialDesc,
                    s.MaterialTypeCode,
                    s.MaterialTypeName,
                    s.BOMVersion,
                    
                    children = roleRepository.Where(x => x.ParentId == s.BOMCode).Select(s => new
                    {
                        Id = s.BOMCode,
                        s.MaterialCode,
                        s.MaterialName,
                        s.BOMCode,
                        s.ParentId,
                        s.MaterialWorkTime,
                        s.MasterUOM,
                        s.MasterQTY,
                        s.ContainerTypeCode,
                        s.VehicleTypeCode,
                        s.IsMaterial,
                        s.isDel,
                        s.MaterialDesc,
                        s.MaterialTypeCode,
                        s.MaterialTypeName,
                        s.BOMVersion,

                        hasChildren = roleRepository.Any(x => x.ParentId == s.BOMCode)
                    }).ToList() 
                })
                .ToList(); 
            return JsonNormal(new { total = query.Count(), rows });
        }

        //public List<Search_MMS_BOMDetailed> GetBOMDetails(string BOMCode)
        //{
        //    List<Search_MMS_BOMDetailed> result = new List<Search_MMS_BOMDetailed>();
        //    var childItems = Search_MMS_BOMDetailedRepository.Instance.FindAsIQueryable(x => x.ParentId == BOMCode);
         

        //    foreach (var childItem in childItems)
        //    {
        //        result.Add(childItem);
        //        result.AddRange(GetBOMDetails(childItem.BOMCode));
        //    }

        //    return result;
        //}

        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> GetChildrenData(string BOMCode)
        {


            var roleRepository = Search_MMS_BOMDetailedRepository.Instance.FindAsIQueryable(x => x.isDel!=1);
            var rows = await roleRepository.Where(x => x.ParentId == BOMCode)
                .Select(s => new
                {
                    Id = s.BOMCode,
                    s.MaterialCode,
                    s.MaterialName,
                    s.BOMCode,
                    s.ParentId,
                    s.MaterialWorkTime,
                    s.MasterUOM,
                    s.MasterQTY,
                    s.ContainerTypeCode,
                    s.VehicleTypeCode,
                    s.IsMaterial,
                    s.isDel,
                    s.MaterialDesc,
                    s.MaterialTypeCode,
                    s.MaterialTypeName,
                    s.BOMVersion,

                    hasChildren = roleRepository.Any(x => x.ParentId == s.BOMCode)
                }).ToListAsync();
            return JsonNormal(new { rows });
        }



    }
}
