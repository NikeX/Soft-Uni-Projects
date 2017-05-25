using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                byte number = Byte.Parse(Console.ReadLine());
                if (number > 255)
                {
                    Console.WriteLine(number);
                    Console.WriteLine("bigger");
                }
                else
                {
                    Console.WriteLine(number);
                }
                

            }

        }
    }
}