using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using CTC_Latest_4._0.DBRepository;

namespace CTC_Latest_4._0.Helper
{
    public class UsingFunctions
    {
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        public string GetIP(string name, string email, string GUID, string code, string isActive, string payment)
        {
            string strHostName = "";

            strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            //string ipaddress = Convert.ToString(ipEntry.AddressList[2]);
            string ipaddress = Convert.ToString(ipEntry.AddressList[1]);

            _dbRepository.InsertQueryRegister_1(name, email, GUID, strHostName, ipaddress, code, isActive, payment);

            return ipaddress.ToString();


        }
    }
}