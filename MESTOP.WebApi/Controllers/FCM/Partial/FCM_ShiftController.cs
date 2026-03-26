/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("FCM_Shift",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Entity.DomainModels;
using FCM.IServices;
using FCM.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MESTOP.Core.Filters;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography.X509Certificates;
using MESTOP.Core.Extensions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using static MESTOP.Entity.DomainModels.FCM_Shift;

namespace FCM.Controllers
{
    public partial class FCM_ShiftController
    {
        private readonly IFCM_ShiftService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public FCM_ShiftController(
            IFCM_ShiftService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [Route("getHdayTotal"), HttpGet]
        [ApiActionPermission]
        [AllowAnonymous]
        public async Task<IActionResult> GetDetailRows(DateTime StartDy, DateTime EndDy)
        {
            
      
            TimeSpan days = new TimeSpan(EndDy.Ticks - StartDy.Ticks);
      
            var rows = await FCM_HolidayRepository.Instance.FindAsIQueryable(x => x.TheDay >= StartDy && x.TheDay < EndDy).ToListAsync();
            var daysCount = days.Days + 1 - rows.Count; 
               
            return JsonNormal(daysCount + "," + rows.Count);
        }
         
    }

 
}
