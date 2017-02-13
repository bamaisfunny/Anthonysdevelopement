using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1_prg
{
    public class Person
    {
        protected string m_firstName;
        protected int m_age;
        protected string m_hairColor;
        protected string m_lastName;
        protected int m_numberReference;

        public Person(string firstName, int age, string hairColor, string lastName)
        {
            this.m_firstName = firstName;
            this.m_age = age;
            this.m_hairColor = hairColor;
            this.m_lastName = lastName;
        }

        public int Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = Age;
            }
        }

        public string FirstName
        {
            get
            {
                return m_firstName;
            }
            set
            {
                m_firstName = FirstName;
            }
        }

        public string HairColor
        {
            get
            {
                return m_hairColor;
            }
            set
            {
                m_hairColor = HairColor;
            }
        }

        public string LastName
        {
            get
            {
                return m_lastName;
            }
            set
            {
                m_lastName = LastName;
            }
        }

        public string getFirstName()
        {
            return m_firstName;
        }

        public int numberReferences()
        {
            return m_numberReference;
        }

        public void printOutContent()
        {
            Console.WriteLine(m_firstName, m_lastName, m_age, m_hairColor);
        }

        public void setFirstName(string name)
        {
            FirstName = name;
        }
    }
}
