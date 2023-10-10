using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XlPrinterUserController.Tests
{
    public class SaveSerializedDataTests
    {
        [Fact]
        public void Save_ReturnMessage()
        {
            // Arrange
            string databaseServer = "dbServer";
            string databaseUser = "dbUser";
            string passwordUser = "dbPassword";
            string database = "dbName";
            string keyServer = "keyServer";
            string xlUser = "xlUser";
            string xlPass = "xlPassword";
            string xlBase = "xlBase";
            string version = "1";

            // Tworzenie obiektu SaveSerializedData
            var saveData = new SaveSerializedData(databaseServer, databaseUser, passwordUser, database, keyServer, xlUser, xlPass, xlBase, version);

            // Act
            string result = saveData.Save();

            // Assert
            // Sprawdź, czy pliki JSON zostały utworzone
            string xlPath = @"C:\Users\kajtuch\Desktop\XLLoginInfo.json";
            string dbPath = @"C:\Users\kajtuch\Desktop\DBLoginInfo.json";

            Assert.True(File.Exists(xlPath));
            Assert.True(File.Exists(dbPath));

            // Dodatkowo, możesz przeczytać zawartość plików JSON i sprawdzić, czy dane są poprawne
            // Możesz dodać kod do odczytu plików JSON i sprawdzenia ich zawartości, ale to zależy od Twoich potrzeb.

            // Oczekujemy, że metoda zwróci odpowiedni komunikat
            Assert.Equal("fasfasfasf", result);
        }
    }
}
