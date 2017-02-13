using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week1_prg
{
    public class GuiPrinter : IPrinter
    {
        public void Print(Student s)
        {
            MessageBox.Show(s.FirstName + " " + s.LastName + " " + s.Age + " " + s.HairColor);

        }
    }
}
