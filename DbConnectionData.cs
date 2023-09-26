using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlActions
{
    class DbConnectionData : IConnectionData
    {
        public ConnectionData GetConnectionData()
        {
            string connectionDataSerialized = File.ReadAllText(@"C:\Users\kajetan.gulbinowicz\Desktop\DbLoginInfo.json");
            ConnectionData connectionData = JsonConvert.DeserializeObject<ConnectionData>(connectionDataSerialized);
            return connectionData;
        }
    }
}
