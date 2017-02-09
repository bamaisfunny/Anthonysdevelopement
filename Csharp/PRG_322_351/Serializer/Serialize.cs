using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Week1_prg;

namespace Serializer
{
   public enum SerializerSource
    {
        fromNothing,
        fromFile,
        fromSQL
    }
    public class Serialize : Read_Write
    {
        string studentInfo;
        MySqlConnection con;
        public Serialize(SerializerSource src = SerializerSource.fromNothing)
        {
            
        }
        public void Serialized(Student s)
        {
            loadStudentFromSQL(s);
        }
        private void loadStudentFromSQL(Student s, string host = "127.0.0.1", string user = "root", string database = "PRG_351")
        {
            con = new MySqlConnection();
            string thatConnection = "server=" + host + ";uid" + user + ";database" + database;
            con.ConnectionString = thatConnection;
            con.Open();
            if(con.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Too Bad");
                return;
            }
            string query = "select * from Students";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            int FieldCount = reader.FieldCount;
            for(int i = 0; i< FieldCount; i++)
            {
                string curField = reader.GetString(i);
            }
        }
        public void writeInfo()
        {
            
        }

        public void writeStudentInfo(Student s, string host = "127.0.0.1", string user = "root", string database = "PRG_351")
        {
            studentInfo = "( \"" +
                s.FirstName +
                "\", " +
                s.Age +
                ", " +
                "\"" +
                s.HairColor +
                "\"" +
                ", " +
                "\"" +
                s.LastName +
                "\");";

            string insert = ("insert into Students values " + studentInfo);
            con = new MySqlConnection();
            string thatConnection = "server=" + host + ";uid=" + user + ";database=" + database;
            con.ConnectionString = thatConnection;
            con.Open();
            if (con.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Too Bad");
                return;
            }
            MySqlCommand cmd = new MySqlCommand(insert, con);
            cmd.ExecuteReader();
        }
    }
}
