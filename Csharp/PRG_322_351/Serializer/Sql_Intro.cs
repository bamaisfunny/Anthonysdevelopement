using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql;

namespace Serializer
{
    public class Sql_Intro
    {
        public static void TestMethod()
        {
            MySqlConnection connection = new MySqlConnection();
            string myConnectionString = "";
            string database = "PRG_321";
            myConnectionString = "server=127.0.0.1;uid=root;" + "database=" + database;
            connection.Open();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection not open - Aborting");
                connection.Close();
                return;
            }
            Console.WriteLine("Connection Open!");
            string query = "select * from Students";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader Reader = cmd.ExecuteReader();
            int Attribute_Count = Reader.
        }
    }
}
