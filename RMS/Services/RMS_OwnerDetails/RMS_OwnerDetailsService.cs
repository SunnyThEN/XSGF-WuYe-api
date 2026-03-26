/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下RMS_OwnerDetailsService与IRMS_OwnerDetailsService中编写
 */
using RMS.IRepositories;
using RMS.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace RMS.Services
{
    public partial class RMS_OwnerDetailsService : ServiceBase<RMS_OwnerDetails, IRMS_OwnerDetailsRepository>
    , IRMS_OwnerDetailsService, IDependency
    {
    public static IRMS_OwnerDetailsService Instance
    {
      get { return AutofacContainerModule.GetService<IRMS_OwnerDetailsService>(); } }
    }
 }
