using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Core.DBManager;
using MESTOP.Entity.SystemModels;
using System.Reflection.Emit;

namespace MESTOP.Core.EFDbContext
{
    public class SysDbContext : BaseDbContext, IDependency
    {
        protected override string ConnectionString
        {
            get
            {
                return DBServerProvider.SysConnectingString;
            }
        }
        public SysDbContext() : base() { }

        public SysDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.UseDbType(optionsBuilder, ConnectionString);
            //默认禁用实体跟踪
            optionsBuilder = optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    //重置系统表名小写
            //    if (entity.GetTableName().StartsWith("Sys_"))
            //    {
            //        entity.SetTableName(entity.GetTableName().ToLower());
            //    }
            //    //// 重置所有列名
            //    //foreach (var property in entity.GetProperties())
            //    //{
            //    //    //StoreObjectIdentifier
            //    //    property.SetColumnName(property.Name);
            //    //}
            //}

            base.OnModelCreating(modelBuilder, typeof(SysEntity));
        }
    }
}
