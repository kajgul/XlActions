using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlActions
{
    public static class DbGetDocuments
    {
        public static List<string> GetDocumentsId(SqlConnection sqlConnection)
        {
            string exec = "select TrN_GIDNumer from cdn.tranag where TrN_GIDTyp = 2033 and TrN_Stan = 2";
            try
            {
                var documents = sqlConnection.Query<string>(exec).ToList();
                var listOfIds = new List<string>();
                foreach (var d in documents)
                {
                    listOfIds.Add(d);
                }

                return listOfIds;
            }
            catch(SqlException sqlException)
            {
                Console.WriteLine("Database connection ERROR - application will be close. Press any key to continue.");
            //    Console.ReadLine();
            //    Environment.Exit(0);
                return null;
            }
        }
    }
}
