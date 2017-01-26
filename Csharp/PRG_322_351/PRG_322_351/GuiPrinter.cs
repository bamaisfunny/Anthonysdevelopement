using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week1_prg
{
    public class GUIPrinter : IPrinter
    {
        public  void Print(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
