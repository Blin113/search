using System;
using System.Collections.Generic;
using System.Text;

namespace search
{
    class Person
    {
        private string name;
        private int age;
        private string adress;
        private int personnum;

        public Person(string n, int ag, string ad, int pn)
        {
            name = n;
            age = ag;
            adress = ad;
            personnum = pn;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Invalid input");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int Personnum
        {
            get { return personnum; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    personnum = 0;
                }
                else
                {
                    personnum = value;
                }
            }
        }
    }
}
