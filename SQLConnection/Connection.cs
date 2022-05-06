using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLConnectionExample
{
    public class Connection
    {
        public static void sqlConnectionMain()
        {
            string connectionString = "Server=localhost;Database=CursoC#;UID=mavs;PWD=password;"; //ubicacion de base de datos
            using (SqlConnection connection = new SqlConnection(connectionString) )
            {
                
                connection.Open();
                //aqui ejecutamos la operacion de la base de datos
            } //automaticamente se cierra la base de datos con IDisposable 

            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = connectionString;
            sqlConnectionStringBuilder.InitialCatalog = connectionString;
            connectionString = sqlConnectionStringBuilder.ToString();
        }

    }
}
