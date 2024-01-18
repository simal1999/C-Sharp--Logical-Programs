using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_an_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multi= 1;
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++) 
            {
                multi *= i;
            }
            Console.WriteLine($"Multiplication result is:{multi}");
            Console.ReadLine();
        }
    }
}
