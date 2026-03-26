/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下RMS_VacantRoomService与IRMS_VacantRoomService中编写
 */
using RMS.IRepositories;
using RMS.IServices;
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;

namespace RMS.Services
{
    public partial class RMS_VacantRoomService : ServiceBase<RMS_VacantRoom, IRMS_VacantRoomRepository>
    , IRMS_VacantRoomService, IDependency
    {
    public static IRMS_VacantRoomService Instance
    {
      get { return AutofacContainerModule.GetService<IRMS_VacantRoomService>(); } }
    }
 }
