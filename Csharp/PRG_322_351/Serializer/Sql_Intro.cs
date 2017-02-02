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
        public static MySqlConnection connection;
        public static void TestMethod()
        {
            MySqlConnection connection = new MySqlConnection();
            string myConnectionString = "";
            string database = "PRG_321";
            myConnectionString = "server=127.0.0.1;uid=root;" + "database=" + database;
            connection.ConnectionString = myConnectionString;
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
            int Attribute_Count = Reader.FieldCount;
            while(Reader.Read())
            {
                String row = "";
                for (int i = 0; i < Attribute_Count; i++)
                    row += Reader.GetString(i) + " - ";
                Console.WriteLine(row);
            }
            connection.Close();
        }
        public static MySqlDataReader RunQueryReturnReader( String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader Reader = cmd.ExecuteReader();
            return Reader;
        }
        public static void CreateDatabase(String db_name, String server, String user = "root")
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            String CnxString = "server=" + server + "; uid=" + user + "database=" + db_name;
            connection.ConnectionString = CnxString;
        }
    }
}
