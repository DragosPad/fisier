using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, fact;
            System.Console.WriteLine("number is: ");
            n = int.Parse(Console.ReadLine());
            fact = n;
            for (c = n - 1; c >= 1; c--)
            {
                fact = fact * c;
            }
            Console.WriteLine("The number you entered was {0} and it's factorial is {1}", n, fact);
            Console.ReadLine();
        }
    }
}
