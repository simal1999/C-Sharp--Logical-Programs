using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q_10_checking_prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {//checking given number is prime number or not
            Console.Write("Enter your number :\t");
            int n=int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i=2; i<n; i++)
            {
                if(n%i==0)
                {
                    Count++;
                }
            }
            if (Count == 0)
                Console.WriteLine($"{n} is prime number.");
            else
                Console.WriteLine($"{n} is not a prime number.");
            Console.ReadLine();
        }
    }
}
