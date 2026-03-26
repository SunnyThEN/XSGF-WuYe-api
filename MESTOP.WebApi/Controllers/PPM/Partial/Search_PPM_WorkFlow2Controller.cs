/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Search_PPM_WorkFlow2",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PPM.IServices;
using MESTOP.Core.Enums;
using MESTOP.Core.Filters;
using PPM.Repositories;
using MESTOP.Core.Extensions;
using System.Linq;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace PPM.Controllers
{
    public partial class Search_PPM_WorkFlow2Controller
    {
        private readonly ISearch_PPM_WorkFlow2Service _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public Search_PPM_WorkFlow2Controller(
            ISearch_PPM_WorkFlow2Service service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        public override ActionResult GetPageData([FromBody] PageDataOptions loadData)
        {


            return GetmainRootData(loadData);

            //return GetTreeTableRootData(loadData).Result;

        }


        [HttpPost, Route("GetmainRootData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public ActionResult GetmainRootData([FromBody] PageDataOptions options)
        {
     
 


            var roleRepository = Search_PPM_WorkFlow2Repository.Instance.FindAsIQueryable(x => 1 == 1);


            var searchname = string.Empty;
            var searchcode = string.Empty;
            //页面加载根节点数据条件x => x.ParentId == 0,自己根据需要设置
            var query = Search_PPM_WorkFlow2Repository.Instance.FindAsIQueryable(x => x.ParentId == null);
            if (!string.IsNullOrEmpty(options.Wheres))
            {
                try
                {
                    var searchParametersList = options.Wheres.DeserializeObject<List<SearchParameters>>();
                    if (searchParametersList.Count() >0)
                    {
                        foreach (var search in searchParametersList)
                        {  
                        if(search.Name== "ProcessFlowCode"&&!string.IsNullOrEmpty(search.Value) )
                            { 
                                query = query.Where (x => x.ProcessFlowCode.Contains(search.Value)); 
                            }
                        }

                    }

                }
                catch { }
            }
        

            var rows = query.TakeOrderByPage(options.Page, options.Rows) 
            .OrderBy(x => x.ProcessFlowCode)
            .Select(s => new
            {
                s.ProcessFlowName   ,
                s.ProcessFlowCode  ,
                s.BOMCode ,
                s.MaterialCode  ,
                s.MaterialShortNo   ,
                s.MaterialName ,
                s.WorkFlow_Id ,
                s.isDel  ,
                s.ParentId,
                children = roleRepository.Where(x => x.ParentId == s.WorkFlow_Id).ToList()
              
            }).ToList(); 

            return JsonNormal(new { total = query.Count(), rows });
        }
        [HttpPost, Route("getChildrenData")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<ActionResult> GetChildrenData(string WorkFlow_Id)
        {


            var roleRepository = Search_PPM_WorkFlow2Repository.Instance.FindAsIQueryable(x => 1 == 1);
            var rows = await roleRepository.Where(x => x.ParentId.ToString() == WorkFlow_Id)
                .Select(s => new
                {
                    s.ProcessFlowName,
                    s.ProcessFlowCode,
                    s.BOMCode,
                    s.MaterialCode,
                    s.MaterialShortNo,
                    s.MaterialName,
                    s.WorkFlow_Id,
                    s.isDel,
                    s.ParentId,
                    //children = roleRepository.Where(x => x.ParentId == s.MWOId).ToList()
                    hasChildren = roleRepository.Any(x => x.ParentId == s.WorkFlow_Id)
                }).ToListAsync();
            return JsonNormal(new { rows });
        }
    }
}
