using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {// factorial of an given number:
            int multi = 1;
            Console.Write("Enter your number:");
            int n=int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine($"The factorial of {n} is {multi}");
            else if (n<0)
                Console.WriteLine("Enter positive nuumber");
            else
            {
                for(int i = n; i >= 1; i--)
                {
                    multi *= i;
                }
                Console.WriteLine($"The factorial of {n} is {multi}");
            }
            Console.ReadLine();
        }
    }
}
