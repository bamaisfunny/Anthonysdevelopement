using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public class StudentRoster : Dictionary<int, Student>
    {

        public void Add(int key, Student value )
        {
            base.Add(key, value);
        }
    }
}
