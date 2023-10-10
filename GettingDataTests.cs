using System;
using System.IO;
using Newtonsoft.Json;
using Xunit;

namespace XlPrinterUserController.Tests
{
    public class GettingDataTests
    {
        [Fact]
        public void GetConnectionData_ValidFilePath_ReturnsDeserializedData()
        {
            // Arrange
            string filePath = "validConnectionData.json";
            var expectedData = new ConnectionSet(); // Zastąp "YourDataType" odpowiednim typem

            // Tworzenie pliku z danymi
            File.WriteAllText(filePath, JsonConvert.SerializeObject(expectedData));

            // Act
            var actualData = GettingData<ConnectionSet>.GetConnectionData(filePath);

            // Assert
            Assert.Equal(expectedData, actualData);
        }

        [Fact]
        public void SaveConnectionData_ValidFilePath_SavesDataToFile()
        {
            // Arrange
            string filePath = "savedConnectionData.json";
            var dataToSave = new ConnectionSet(); // Zastąp "YourDataType" odpowiednim typem

            // Act
            GettingData<ConnectionSet>.SaveConnectionData(filePath, dataToSave);

            // Assert
            Assert.True(File.Exists(filePath));
            var savedData = File.ReadAllText(filePath);
            var deserializedData = JsonConvert.DeserializeObject<ConnectionSet>(savedData);
            Assert.Equal(dataToSave, deserializedData);

            // Clean up
            File.Delete(filePath);
        }
    }
}