using System;
using XlActions;

namespace XLWydruk
{
    class Program
    {
        static void Main(string[] args)
        {
            var xlConnection = new XlConnection();
            xlConnection.Connection();
            xlConnection.Login();

            var wydruk = new PrintFromXl();
            var connection = DbConnection.Connect();
            var listOfIds = DbGetDocuments.GetDocumentsId(connection);
            try
            {
                foreach (var id in listOfIds)
                {
                    wydruk.Print(20220, $"(TrN_GIDTyp=2033 AND TrN_GIDNumer={id})", id);
                }
                xlConnection.Logout();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();                
        }
    }
}
