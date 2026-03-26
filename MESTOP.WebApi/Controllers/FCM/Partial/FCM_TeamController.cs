/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("FCM_Team",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using FCM.IServices;
using FCM.Services;
using FCM.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FCM.Controllers
{
    public partial class FCM_TeamController
    {
        private readonly IFCM_TeamService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IFCM_TeamMemberRepository _teamMemberRepository;

        [ActivatorUtilitiesConstructor]
        public FCM_TeamController(
            IFCM_TeamService service,
            IHttpContextAccessor httpContextAccessor,
            IFCM_TeamMemberRepository teamMemberRepository
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _teamMemberRepository = teamMemberRepository;
        }
        /// <summary>
        /// 获取班组下面的班组成员
        /// </summary>
        /// <param name="TeamId">班组主键</param>
        /// <returns></returns>
        [Route("getDetailRows"), HttpGet]
        public async Task<IActionResult> GetDetailRows(string TeamId)
        {
            var rows = await _teamMemberRepository.FindAsIQueryable(x => x.TeamId == new Guid(TeamId))
                  .ToListAsync();
            return JsonNormal(rows);
        }
        [HttpPost, Route("getSelectorTeam")]
        public IActionResult getSelectorTeam([FromBody] PageDataOptions options)
        {
            //1.可以直接调用框架的GetPageData查询
            PageGridData<FCM_Team> data = FCM_TeamService.Instance.GetPageData(options);
            return JsonNormal(data);
        }
    }
}
