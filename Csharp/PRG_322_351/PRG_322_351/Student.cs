using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public class Student : Person,IDebug,IContactable 
    {
        private string email;
        private int id;
        public int idCount = 0;
        private string phoneNumber;

        public Student(string firstName, int age, string hairColor, string lastName)
         :base(firstName, age, hairColor, lastName)
        {
            this.m_firstName = firstName;
            this.m_lastName = lastName;
            this.m_age = age;
            this.m_hairColor = hairColor;
            idCount++;
        }

        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                email = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public void PrepareDebugInfo()
        {
            throw new System.NotImplementedException();

        }

        public void Debug()
        {
            string x = (this.m_firstName + " " + this.m_lastName + " " + this.m_age.ToString() + " " + this.m_hairColor);
            stuPrinter.Print(x);
        }
        public IPrinter stuPrinter;
    }
}
