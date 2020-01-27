using System;
using System.Collections.Generic;

namespace search
{
    class Program
    {

        static string accumulator = "";
        static void Main(string[] args)
        {
            List<Person> personlista = new List<Person>();

            personlista.Add(new Person("Armin Rezaie", 17, "Tjädervägen 11", 20020822));
            personlista.Add(new Person("Test person", 17, "testväg 1", 20020101));

            Console.WriteLine("Search: "+accumulator+"\n");
            
            var info = Console.ReadKey();
            Console.Clear();
            switch (info.Key)
            {
                case ConsoleKey.Backspace:
                    if (accumulator.Length == 0){
                        break;
                    }
                    accumulator = accumulator.Remove(accumulator.Length - 1); 
                    break;
                
                case ConsoleKey.Space:
                    accumulator += " ";

                default:
                    accumulator += info.Key.ToString().ToLower();
                    break;
            }

            List<int> result = LinSearch(personlista, accumulator);

            foreach(int index in result)
            {
                Console.WriteLine("Name: " + personlista[index].Name);
                Console.WriteLine("Age: " + personlista[index].Age);
                Console.WriteLine("Adress: " + personlista[index].Adress);
                Console.WriteLine("Social security number: " + personlista[index].Personnum + "****");
                Console.WriteLine();
            }
            Main(null);
        }

        public static List<int> LinSearch(List<Person> pl, string Key)
        {
            Key = Key.ToLower();
            List<int> result = new List<int>();
            for (int i = 0; i < pl.Count; i++) 
            {
                if (Key == pl[i].Personnum+"")
                {
                    result.Add(i);
                }
                
                else if (Key == pl[i].Age+"")
                {
                    result.Add(i);
                }

                else if (pl[i].Name.ToLower().Contains(Key))
                {
                    result.Add(i);
                }

                else if (pl[i].Adress.ToLower().Contains(Key))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
