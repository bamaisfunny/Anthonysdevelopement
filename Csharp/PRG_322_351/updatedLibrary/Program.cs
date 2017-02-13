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
            Student Anthony = new Student("Anthony", 28, "none", "Searles");
            GuiPrinter s = new GuiPrinter();
            ConsolePrinter x = new ConsolePrinter();

            s.Print(Anthony);
            x.Print(Anthony);

        }
    }
}
