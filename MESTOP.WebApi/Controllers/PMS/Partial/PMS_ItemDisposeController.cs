/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PMS_ItemDispose",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PMS.IServices;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using PMS.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MESTOP.Core.Extensions;
using MESTOP.Core.ManageUser;

namespace PMS.Controllers
{
    public partial class PMS_ItemDisposeController
    {
        private readonly IPMS_ItemDisposeService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PMS_ItemDisposeController(
            IPMS_ItemDisposeService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return GetRootData(loadData);
            //return GetTreeTableRootData(loadData).Result;

        }


        [HttpPost, Route("GetRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetRootData([FromBody] PageDataOptions options)
        {
            var roleRepository = PMS_ItemDisposeRepository.Instance.FindAsIQueryable(x => 1 == 1);

            //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置
            //var Itemuser = "admin," + PMS_ItemPathRepository.Instance.FindAsIQueryable(s => s.PId == q.PId && s.Itemtype == q.Itemtype).Select(s => s.ItemUser).FirstOrDefault();

            var query = PMS_ItemDisposeRepository.Instance.FindAsIQueryable(x => (x.parentId == 0 || x.parentId == null)&&("admin,"+x.ItemUser).Contains(UserContext.Current.UserName) && x.isDel != 1);
            var rows = query.TakeOrderByPage(options.Page, options.Rows)
                .OrderBy(x => x.ItemID).Select(s => new
                {
                    s.ItemEng,
                    s.ItemID,
                    s.ItemFullPath,
                    s.CreateDate,
                    s.Creator,
                    s.ItemName,
                    s.isDel,
                    s.parentId,
                    s.VerItemEng,
                    s.VerItemName,
                    s.Itemtype,
                    s.PId,
                    s.ItemUser,
                    children = roleRepository.Where(x => x.parentId == s.ItemID).Select(s => new
                    {
                        s.ItemEng,
                        s.ItemID,
                        s.ItemFullPath,
                        s.CreateDate,
                        s.Creator,
                        s.ItemName,
                        s.isDel,
                        s.parentId,
                        s.VerItemEng,
                        s.VerItemName,
                        s.Itemtype,
                        s.PId,
                        s.ItemUser,
                        children = roleRepository.Where(x => x.parentId == s.ItemID).ToList(),

                    }).ToList(),
              
                }).ToList();



            return JsonNormal(new { total = query.Count(), rows });
        }



        //[HttpPost, Route("getChildrenData")]
        //[ApiActionPermission(ActionPermissionOptions.Search)]
        public static object GetChildrenData(int MWOId)
        {


            var roleRepository = PMS_ItemDisposeRepository.Instance.FindAsIQueryable(x => 1 == 1 && x.isDel != 1);
            var rows = roleRepository.Where(x => x.parentId == MWOId)
                .Select(s => new
                {
                    s.ItemEng,
                    s.ItemID,
                    s.ItemFullPath,
                    s.CreateDate,
                    s.Creator,
                    s.ItemName,
                    s.isDel,
                    s.parentId,
                    s.VerItemEng,
                    s.VerItemName,
                    s.PId,
                    s.ItemUser,
                    children = roleRepository.Where(x => x.parentId == s.ItemID).ToList(),
                   // hasChildren = roleRepository.Any(x => x.parentId == s.ItemID)
                }).ToListAsync();
            return rows;
        }
    }
}
