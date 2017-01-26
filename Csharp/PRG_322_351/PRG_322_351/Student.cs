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
        private int printer;

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
                email = Email;
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
                id = Id;
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
                phoneNumber = PhoneNumber;
            }
        }

        public void PrepareDebugInfo()
        {
            throw new System.NotImplementedException();

        }

        public void Debug()
        {
            Console.WriteLine(this.m_firstName, this.m_lastName, this.m_age, this.m_hairColor);

        }
    }
}
