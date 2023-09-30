using Newtonsoft.Json;
using System.IO;

namespace XlPrinterUserController
{
    public class SaveSerializedData
    {
        private ConnectionSet _xlData;
        private ConnectionSet _dbData;

        public SaveSerializedData(string databaseServer, string databaseUser, string passworduser, string database, string keyServer, string xlUser, string xlPass, string xlbase, string v)
        {
            _xlData = new ConnectionSet();
            _xlData.ServerName = keyServer;
            _xlData.DbName = xlbase;
            _xlData.User = xlUser;
            _xlData.Password = xlPass;
            _xlData.Version = int.Parse(v);

            _dbData = new ConnectionSet();
            _dbData.ServerName = databaseServer;
            _dbData.DbName = database;
            _dbData.User = databaseUser;
            _dbData.Password = passworduser;
        }

        public void Save() 
        {
            var xlPath = @"C:\Users\kajtuch\Desktop\XLLoginInfo.json";
            GettingData<ConnectionSet>.SaveConnectionData(xlPath, _xlData);

            var dbPath = @"C:\Users\kajtuch\Desktop\DBLoginInfo.json";
            GettingData<ConnectionSet>.SaveConnectionData(dbPath, _dbData);
        }
    }
}