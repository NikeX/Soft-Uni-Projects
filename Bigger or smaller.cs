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
            int n = 5;
            int p = 1;
            n = n >> p;
            if (n == 1)
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");

            }
           
        }
    }
}