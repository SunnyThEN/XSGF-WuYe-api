/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下RMS_PaymentDetailsService与IRMS_PaymentDetailsService中编写
 */
using RMS.IRepositories;
using RMS.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace RMS.Services
{
    public partial class RMS_PaymentDetailsService : ServiceBase<RMS_PaymentDetails, IRMS_PaymentDetailsRepository>
    , IRMS_PaymentDetailsService, IDependency
    {
    public static IRMS_PaymentDetailsService Instance
    {
      get { return AutofacContainerModule.GetService<IRMS_PaymentDetailsService>(); } }
    }
 }
