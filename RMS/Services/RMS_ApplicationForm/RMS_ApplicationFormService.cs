/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下RMS_ApplicationFormService与IRMS_ApplicationFormService中编写
 */
using RMS.IRepositories;
using RMS.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace RMS.Services
{
    public partial class RMS_ApplicationFormService : ServiceBase<RMS_ApplicationForm, IRMS_ApplicationFormRepository>
    , IRMS_ApplicationFormService, IDependency
    {
    public static IRMS_ApplicationFormService Instance
    {
      get { return AutofacContainerModule.GetService<IRMS_ApplicationFormService>(); } }
    }
 }
