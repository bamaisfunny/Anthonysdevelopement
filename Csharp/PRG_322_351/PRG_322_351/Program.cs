using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_prg
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Anthony", 28, "Blonde", "Searles");
            StudentRoster x = new StudentRoster();
            s.Id = 6;
            x.Add(s.Id, s);
            foreach(KeyValuePair<int , Student > kvp in x)
            {
                Console.WriteLine(s.FirstName + " was added to the roster.");
                Console.WriteLine("These are the students on the roster: " + kvp.Value.FirstName + " and their id is " + kvp.Value.Id);
                Console.WriteLine("This is " + s.FirstName + "'s profile info: " + s.Debug());

            }
            Console.ReadKey();
        }
    }
}
