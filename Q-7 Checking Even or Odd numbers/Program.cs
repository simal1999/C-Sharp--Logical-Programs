using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7_Checking_Even_or_Odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {// checking given number is even or odd number
            Console.Write("Enter your number :\t");
            int i=int.Parse(Console.ReadLine());
            if (i % 2 == 0)// % will gives the remainder of the division
                Console.Write($"{i} is even number.");
            else
                Console.Write($"{i} is odd  number.");
            Console.ReadLine();
        }
    }
}
