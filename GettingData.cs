using Newtonsoft.Json;
using System.IO;

namespace XlPrinterUserController
{
    public static class GettingData<T>
    {
        public static T GetConnectionData(string filePath)
        {
            string connectionDataSerialized = File.ReadAllText(filePath);
            var connectionData = JsonConvert.DeserializeObject<T>(connectionDataSerialized);
            return connectionData;
        }

        public static void SaveConnectionData(string filePath, T data)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }
    }
}