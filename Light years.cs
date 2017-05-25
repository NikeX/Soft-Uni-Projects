using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                decimal n = 9450000000000m;
                double num1 = (double)n;
                num1 = num1 * 4.22;
                double num2 = (double)(26000m * n);
                double num3 = (double)(100000m * n);
                double num4 = (double)(46500000000m * n);
                
                Console.WriteLine("{0:e2}", num1);
                Console.WriteLine("{0:e2}", num2);
                Console.WriteLine("{0:e2}", num3);
                Console.WriteLine("{0:e2}", num4);
            }

        }
    }
}