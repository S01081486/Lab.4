using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                }
            }
            {
                Console.Write("Please enter a temperature: ");

                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp >= 90) { Console.WriteLine("Fish"); }

                else if (temp >= 80) { Console.WriteLine("Lion"); }

                else if (temp >= 70) { Console.WriteLine("Turtle"); }

                else if (temp >= 60) { Console.WriteLine("Deer"); }

                else if (temp >= 50) { Console.WriteLine("Reindeer"); }

                else if (temp >= 40) { Console.WriteLine("Moose"); }

                else if (temp >= 30) { Console.WriteLine("Penguin"); }

                else if (temp >= 20) { Console.WriteLine("Polar Bear"); }

                else { Console.WriteLine("Bug"); }
            }
            {
                for (int i = 10; i < 21; i++)
                {
                    Console.WriteLine(i);
                }
            }
            {
                for (int i = 0; i < 101; i++)
                {
                    Console.WriteLine(i);
                    {
                        if ((i % 1) == 0)
                            Console.WriteLine("********");
                    }
                }
            }
        }
    }
}
