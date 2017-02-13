using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(Student s)
        {
            Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age + " " + s.HairColor);
        }
    }
}
