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
            StudentRoster s = new StudentRoster();
            foreach (KeyValuePair<int, Student> kvp in s.studentDictionary)
            {
                kvp.Value.Debug();
            }
        }
    }
}
