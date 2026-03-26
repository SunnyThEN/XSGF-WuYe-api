using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using MESTOP.Core.Enums;
using MESTOP.Core.Extensions;
using MESTOP.Core.ObjectActionValidator;
using MESTOP.Core.Services;
using MESTOP.Core.Utilities;

namespace MESTOP.Core.Filters
{
    public class ActionExecuteFilter : IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //验证方法参数
            context.ActionParamsValidator();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}