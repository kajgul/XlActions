using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace XlActions
{
    public class DbConnection
    { 
        public static SqlConnection Connect() {
            var aConnectionData = new DbConnectionData();       
            var connectionData = aConnectionData.GetConnectionData();

            var connectionString = $"Server={connectionData.ServerName};Database={connectionData.DbName};" +
                $"User Id = {connectionData.User}; Password = {connectionData.Password}";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
