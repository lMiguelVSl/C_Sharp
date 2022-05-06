using SQLConnectionExample;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnection
{
    public class SelectDB
    {
        public static void SelectMain()
        {
            string connectionString = "Server=MAVS;Database=CursoC#;Trusted_Connection=True;"; //url BD
            using (SqlConnection connection = new SqlConnection(connectionString)) //creo la conexion de tipo SqlConnection y le paso el string con la ubicaciom
            {
                SqlCommand command = new SqlCommand("select * from People", connection); //creo sqlcommand el query con la conexion 
                connection.Open(); //abro la conexion con la base de datos
                Console.WriteLine("Connected");
                SqlDataReader DataReader = command.ExecuteReader();  //ejecuto el reader que es poara obtener datos de la base de datos

                while (DataReader.Read()) //mientras exista data para traer 
                {
                    string formatStringWritingMiddleName = "Person ({0}) is named {1} {2} {3}";
                    string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";
                    if ((DataReader["secondname"]==null))
                    {
                        Console.WriteLine(formatStringWithoutMiddleName,
                            DataReader["id"],
                            DataReader["firstname"],
                            DataReader["lastname"]); //agrego el string creado y le concateno las variables para mostrarlas en el orden dicho
                    } else
                    {
                        Console.WriteLine(formatStringWritingMiddleName,
                            DataReader["id"],
                            DataReader["firstname"],
                            DataReader["secondname"],
                            DataReader["lastname"]);//agrego el string creado y le concateno las variables para mostrarlas en el orden dicho
                    }
                }
                DataReader.Close();
                Console.WriteLine("Disconnected");
            }
        }
    }
}
