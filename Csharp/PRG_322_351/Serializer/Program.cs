using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using Week1_prg;

namespace Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Julien", 25, "Black", "Esposito");
            textIO t = new textIO();
            Serialize x = new Serialize();
            t.writeStudentInfo(s);
            t.writeInfo();
            x.writeStudentInfo(s);
            Console.ReadKey();
        }
      
    }
}
