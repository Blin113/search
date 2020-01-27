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

            personlista.Add(new Person("Test Person0", 17, "testväg 0", 20020101));
            personlista.Add(new Person("Test Person1", 17, "testväg 1", 20020202));
            personlista.Add(new Person("Test Person2", 17, "testväg 2", 20020303));
            personlista.Add(new Person("Test Person3", 17, "testväg 3", 20020404));
            personlista.Add(new Person("Test Person4", 17, "testväg 4", 20020505));
            personlista.Add(new Person("Test Person5", 17, "testväg 5", 20020606));
            personlista.Add(new Person("Test Person6", 17, "testväg 6", 20020707));

            Console.SetCursorPosition(0, 0);
            Searchbar();





            List<int> result = LinSearch(personlista, accumulator);

            foreach (int index in result)
            {
                Console.WriteLine("\n_____________________________________________________________________________");
                Console.WriteLine("Name: " + personlista[index].Name);
                Console.WriteLine("Age: " + personlista[index].Age);
                Console.WriteLine("Adress: " + personlista[index].Adress);
                Console.WriteLine("Social security number: " + personlista[index].Personnum + "****");
            }
            Main(null);
        }

        public static List<int> LinSearch(List<Person> pl, string Key)
        {
            Key = Key.ToLower();
            List<int> result = new List<int>();
            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i].Personnum.ToString().Contains(Key + ""))
                {
                    result.Add(i);
                }

                else if (pl[i].Age.ToString().Contains(Key + ""))
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

        public static void Searchbar()
        {
            Console.Write("Search: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(accumulator);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            var info = Console.ReadKey();
            Console.Clear();
            switch (info.Key)
            {
                case ConsoleKey.Backspace:
                    if (accumulator.Length == 0)
                    {
                        break;
                    }
                    accumulator = accumulator.Remove(accumulator.Length - 1);
                    break;

                case ConsoleKey.Spacebar:
                    accumulator += " ";
                    break;

                case ConsoleKey.D0:
                    accumulator += "0";
                    break;

                case ConsoleKey.D1:
                    accumulator += "1";
                    break;

                case ConsoleKey.D2:
                    accumulator += "2";
                    break;

                case ConsoleKey.D3:
                    accumulator += "3";
                    break;

                case ConsoleKey.D4:
                    accumulator += "4";
                    break;

                case ConsoleKey.D5:
                    accumulator += "5";
                    break;

                case ConsoleKey.D6:
                    accumulator += "6";
                    break;

                case ConsoleKey.D7:
                    accumulator += "7";
                    break;

                case ConsoleKey.D8:
                    accumulator += "8";
                    break;

                case ConsoleKey.D9:
                    accumulator += "9";
                    break;

                case ConsoleKey.NumPad0:
                    accumulator += "0";
                    break;

                case ConsoleKey.NumPad1:
                    accumulator += "1";
                    break;

                case ConsoleKey.NumPad2:
                    accumulator += "2";
                    break;

                case ConsoleKey.NumPad3:
                    accumulator += "3";
                    break;

                case ConsoleKey.NumPad4:
                    accumulator += "4";
                    break;

                case ConsoleKey.NumPad5:
                    accumulator += "5";
                    break;

                case ConsoleKey.NumPad6:
                    accumulator += "6";
                    break;

                case ConsoleKey.NumPad7:
                    accumulator += "7";
                    break;

                case ConsoleKey.NumPad8:
                    accumulator += "8";
                    break;

                case ConsoleKey.NumPad9:
                    accumulator += "9";
                    break;

                case ConsoleKey.Oem7:
                    accumulator += "ä";
                    break;

                case ConsoleKey.Oem3:
                    accumulator += "ö";
                    break;

                case ConsoleKey.Oem6:
                    accumulator += "å";
                    break;

                case ConsoleKey.Oem4:
                    accumulator += "´";
                    break;

                case ConsoleKey.Oem1:
                    accumulator += "¨";
                    break;

                case ConsoleKey.Oem2:
                    accumulator += "'";
                    break;

                case ConsoleKey.Divide:
                    accumulator += "/";
                    break;

                case ConsoleKey.Subtract:
                    accumulator += "-";
                    break;

                case ConsoleKey.Multiply:
                    accumulator += "*";
                    break;

                case ConsoleKey.OemPlus:
                    accumulator += "+";
                    break;

                case ConsoleKey.Add:
                    accumulator += "+";
                    break;

                case ConsoleKey.Enter:
                    accumulator += "";
                    break;

                default:
                    Console.Clear();
                    accumulator += info.Key.ToString().ToLower();
                    break;
            }

        }
    }
}
