/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PPM_WorkFlowMaterial",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PPM.IServices;

namespace PPM.Controllers
{
    public partial class PPM_WorkFlowMaterialController
    {
        private readonly IPPM_WorkFlowMaterialService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PPM_WorkFlowMaterialController(
            IPPM_WorkFlowMaterialService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 获取工作流程表数据源
        /// </summary>
        /// <returns></returns>
       
        /// <summary>
        /// 获取流程节点数据源(用户与角色)
        /// </summary>
        /// <returns></returns>
       
        /// <summary>
        /// 获取单据的审批流程进度
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
         
 

 
    }
}
