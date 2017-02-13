using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public class StudentRoster
    {
        public Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
        Student s;

        public StudentRoster()
        {
            studentDictionary.Add(s.Age, s);
            
        }

        public void Add()
        {
            s = new Student("Anthony", 28, "Blonde", "Searles");
        }
    }
}
