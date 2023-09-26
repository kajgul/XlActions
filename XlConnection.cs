using cdn_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlActions
{
    public class XlConnection : IConnection
    { 
        public XLLoginInfo_20220 XlLogin { get; }
        private static int session = 1;
        public XlConnection()
        {
            XlLogin = new XLLoginInfo_20220();
        }    

        public void Connection()
        {
            var aXlConnectionData = new XlConnectionData();
            var xlConnectionData = aXlConnectionData.GetConnectionData();
            XlLogin.Wersja = xlConnectionData.Version;
            XlLogin.ProgramID = "Wydruk";
            XlLogin.OpeIdent = xlConnectionData.User;
            XlLogin.OpeHaslo = xlConnectionData.Password;
            XlLogin.Baza = xlConnectionData.DbName;
            XlLogin.SerwerKlucza = xlConnectionData.ServerName;
            XlLogin.TrybWsadowy = 1;
            XlLogin.UtworzWlasnaSesje = 1;
            XlLogin.Winieta = 1;
        }

        public void Login()
        {
            int loginCode = cdn_api.cdn_api.XLLogin(XlLogin, ref session);
            Console.WriteLine($"Sesja: {session}");
            Console.WriteLine($"Zalogowano z kodem: {loginCode}");
        }

        public void Logout()
        {
            var LogoutInfo = new XLLogoutInfo_20220();
            LogoutInfo.Wersja = XlLogin.Wersja;
            LogoutInfo.TrybUsuwaniaDok = 0;
            long wynik = cdn_api.cdn_api.XLLogoutEx(LogoutInfo, session);
            Console.WriteLine();
            Console.WriteLine($"Wylogowano z kodem {wynik}");
        }

    }
}
