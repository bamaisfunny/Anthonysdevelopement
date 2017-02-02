using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter tw = new System.IO.StreamWriter("C:\\Users\\CCSDUser\\Documents\\PracticeFileWriting\\Example.txt"); 
            tw.WriteLine("Age = " + 28);
            tw.Close();

            System.IO.StreamReader tr = new System.IO.StreamReader("C:\\Users\\CCSDUser\\Documents\\PracticeFileWriting\\Example.txt");
            String line_read = tr.ReadLine();
            string[] age_seperator = { "Age = " };
            string[] value_extracted = line_read.Split(age_seperator, StringSplitOptions.RemoveEmptyEntries);
            int age = Convert.ToInt32(value_extracted[0]);
            Console.WriteLine("Age (read back = " + age);
            Console.ReadKey();
        }
      
    }
}
