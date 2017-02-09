using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_prg;

namespace Serializer
{
    class textIO : Read_Write
    {
        string studentInfo;
        public void writeInfo()
        { 

        System.IO.StreamWriter tw = new System.IO.StreamWriter("C:\\Users\\CCSDUser\\Documents\\PracticeFileWriting\\Example.txt");
        tw.WriteLine(studentInfo);
            tw.Close();

        }
        public void readInfo()
        {
            System.IO.StreamReader tr = new System.IO.StreamReader("C:\\Users\\CCSDUser\\Documents\\PracticeFileWriting\\Example.txt");
            String line_read = tr.ReadLine();
            string[] age_seperator = { "Age = " };
            string[] value_extracted = line_read.Split(age_seperator, StringSplitOptions.RemoveEmptyEntries);
            int age = Convert.ToInt32(value_extracted[0]);
            Console.WriteLine("Age (read back = " + age);
            Console.ReadKey();
        }

        public void writeStudentInfo(Student s)
        {
            studentInfo = (s.FirstName + " " + s.LastName + " " + s.Age + " " + s.HairColor);
            return;
        }
    }
}
