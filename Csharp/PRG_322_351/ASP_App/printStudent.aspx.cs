using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Week1_prg;
using MySql.Data;
using MySql.Data.Entity;
using MySql;
using MySql.Data.MySqlClient;

namespace ASP_App
{
    public partial class printStudent : System.Web.UI.Page , IPrinter
    {
        Student s = new Student("Anthony", 28, "None", "Searles");
        string curField;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        public void Print(Student s)
        {
            Response.Write(curField);
            
        }

        protected void btnStudentInfo_Click(object sender, EventArgs e)
        {
            Serialized(s);
            this.btnStudentInfo.Text = "nice";
        }
             public void Serialized(Student s)
        {
            loadStudentFromSQL(s);
        }
        private void loadStudentFromSQL(Student s, string host = "127.0.0.1", string user = "root", string database = "PRG_351")
        {
            MySqlConnection con = new MySqlConnection();
            string thatConnection = "server=" + host + ";uid=" + user + ";database=" + database;
            con.ConnectionString = thatConnection;
            con.Open();
            if (con.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Too Bad");
                return;
            }
            string query = "select * from Students";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            int FieldCount = reader.FieldCount;
            for (int i = 0; i < 1; i++)
            {
                reader.Read();
                 curField += reader.GetString("firstname");
                curField += reader.GetString("age");
                curField += reader.GetString("haircolor");
                curField += reader.GetString("lastname");

            }

            reader.Close();
            Print(s);
        }

    }

    
}