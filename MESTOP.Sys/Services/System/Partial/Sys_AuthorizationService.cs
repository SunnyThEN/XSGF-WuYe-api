/*
 *所有关于Sys_Authorization类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*Sys_AuthorizationService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;
using System.Linq;
using MESTOP.Core.Utilities;
using System.Linq.Expressions;
using MESTOP.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using MESTOP.Sys.IRepositories;
using MESTOP.Core.Configuration;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MESTOP.Sys.Services
{
    public partial class Sys_AuthorizationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISys_AuthorizationRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public Sys_AuthorizationService(
            ISys_AuthorizationRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }
        WebResponseContent webResponse = new WebResponseContent();


        public string AuthorizationCode(string SYSstr, string MACcode)
        {
            string acode = string.Empty;
            string macaddress = GetMacAddressByNetworkInformation();
            if (!MACcode.IsNullOrEmpty()) macaddress = MACcode; 
            List<DateTime> dateList = new List<DateTime>(); 
            for (int i = 0; i <= 7; i++)
            {
                DateTime date1 = new DateTime(2024 + i, 06, 08);
                dateList.Add(date1);
            }

            // 创建MD5对象并计算MD5值

            DateTime date50 = new DateTime(2050, 06, 08);
            if (SYSstr == "MES.TOP7868")
            { 
                string inputString = date50.ToString("yyyyMMddHHmmss");
                var cc = macaddress.EncryptDES(inputString);
                //acode = macaddress.EncryptDES(AppSetting.Secret.User);

            }
            int m = 0;
            foreach (DateTime d in dateList) 
            {

                if (SYSstr == "MES.TOP" + m.ToString())
                {
                    string inputString = d.ToString("yyyyMMddHHmmss");
                    string md5string = md5str(inputString);
                    acode = macaddress.EncryptDES(md5string);
                    return acode;
                }
                m++;

            }
            return acode;
        } 


        public string  md5str (string inputString)
        {

            string result = string.Empty;

            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString); // 将输入字符串转换成字节数组
            using (var md5Hash = MD5.Create())
            {
                byte[] hashedBytes = md5Hash.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    sb.Append(hashedBytes[i].ToString("x2")); // 将每个字节转换成16进制表示形式
                }

                result = sb.ToString(); // 最终得到的MD5码
            }
            return result;
        }
        public string GetMacAddressByNetworkInformation()
        {
            string key = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\";
            string macAddress = string.Empty;
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                    && adapter.GetPhysicalAddress().ToString().Length != 0)
                    {
                        string fRegistryKey = key + adapter.Id + "\\Connection";
                        RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                        if (rk != null)
                        {
                            string fPnpInstanceID = rk.GetValue("PnpInstanceID", "").ToString();
                            int fMediaSubType = Convert.ToInt32(rk.GetValue("MediaSubType", 0));
                            if (fPnpInstanceID.Length > 3 &&
                            fPnpInstanceID.Substring(0, 3) == "PCI")
                            {
                                macAddress = adapter.GetPhysicalAddress().ToString();
                                for (int i = 1; i < 6; i++)
                                {
                                    macAddress = macAddress.Insert(3 * i - 1, "-");
                                }
                                break;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //这里写异常的处理
                string S = ex.Message.ToString();
            }




            return macAddress;

        }
        public static bool CompareMd5Values(string originalValue, string encodedValue)
        {
            using (var md5Hash = MD5.Create())
            {
                byte[] originalData = Encoding.UTF8.GetBytes(originalValue);
                byte[] encodedData = md5Hash.ComputeHash(originalData);

                return BitConverter.ToString(encodedData).Replace("-", "") == encodedValue;
            }
        }

        public bool getAuthorization()
        {
             List<DateTime> dateList = new List<DateTime>();

            for(int i=0;i<=7;i++)
            {
                DateTime date1 = new DateTime(2024+i, 06, 08);
                dateList.Add(date1);
            }

            string macaddress = GetMacAddressByNetworkInformation();//获得mac
            string MCPW = AppSetting.Secret.MCPW; //获得授权
            DateTime datenow = DateTime.Now;
            foreach (var d in dateList)
           {
            
        
                string inputString = d.ToString("yyyyMMddHHmmss");
                string md5string = md5str(inputString);
                var cc = macaddress.EncryptDES(md5string);
                if (MCPW == cc)
                {
                    if(datenow < d)  //判断是否过期
                    { 
                    return false;   //获得授权
                    }
                }
            }
            return true;

        }

    }
}
