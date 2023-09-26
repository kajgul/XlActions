using Newtonsoft.Json;
using System;
using System.IO;


namespace XlActions
{
    class XlConnectionData : IConnectionData
    {
        public ConnectionData GetConnectionData()
        {
            string connectionDataSerialized = File.ReadAllText(@"C:\Users\kajetan.gulbinowicz\Desktop\XlLoginInfo.json");
            ConnectionData connectionData = JsonConvert.DeserializeObject<ConnectionData>(connectionDataSerialized);
            return connectionData;
        }
    }
}
