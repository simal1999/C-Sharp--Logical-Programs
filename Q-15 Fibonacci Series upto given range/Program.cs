using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_15_Fibonacci_Series_upto_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {//Fibonacii series upto given range
            Console.Write("Enter your number range to see fibonacii series:\t");
            int n=int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            Console.WriteLine($"Fabonacii series with in the range of {n} are:");
            while (a < n) 
            {
                Console.Write(a + " ");
                sum = a + b;
                a = b;
                b = sum;
            }
            Console.ReadLine();
        }
    }
}
