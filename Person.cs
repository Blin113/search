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
        //private int personnumL4;

        public Person(string n, int ag, string ad, int pn/*, int L4*/)
        {
            name = n;
            age = ag;
            adress = ad;
            personnum = pn;
            //personnumL4 = L4;
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
            get 
            {
                return personnum;
            }
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
        /*
        public int PersonnumL4
        {
            get { return personnumL4; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    personnumL4 = 0;
                }
                else
                {
                    personnumL4 = value;
                }
            }
        }
        */
    }
}
