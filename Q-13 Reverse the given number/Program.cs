using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13_Reverse_the_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {// Reversing the given number
            Console.Write("Enter your number to reverse:\t");
            int a=int.Parse(Console.ReadLine());
            int rem, b = 0;
            while(a!=0)
            {
                rem = a % 10;
                b = (b * 10) + rem;
                a = a / 10;
            }
            Console.WriteLine($"The reverse of your number is:\t{b}");
            Console.ReadLine();
        }
    }
}
