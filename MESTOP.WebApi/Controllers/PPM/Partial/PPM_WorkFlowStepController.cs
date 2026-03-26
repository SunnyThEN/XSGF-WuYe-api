/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("PPM_WorkFlowStep",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using PPM.IServices;
using PPM.Repositories;
using System.Linq;

namespace PPM.Controllers
{
    public partial class PPM_WorkFlowStepController
    {
        private readonly IPPM_WorkFlowStepService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public PPM_WorkFlowStepController(
            IPPM_WorkFlowStepService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpPost, Route("DelStep")]
        public ActionResult DelStep([FromBody] object[] keys)
        {

            var steps = PPM_WorkFlowStepRepository.Instance.FindAsIQueryable(x => x.StepId == Guid.Parse(keys[0].ToString())).Select(s => new { s.WorkStepFlow_Id }).ToList();


            List<string> keylist = new List<string>();
            foreach (var step in steps)
            {
                var S = step.WorkStepFlow_Id.ToString().ToLower();
                keylist.Add(S);
            }



            return base.Del(keylist.ToArray());
        }

    }
}
