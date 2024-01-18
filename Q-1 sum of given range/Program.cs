using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sum_of_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {//sum of given range
            int i = 1;
            int count = 0;
            Console.WriteLine("Enter given range:");
            int j=int.Parse(Console.ReadLine());
            while (i<=j)
            {
                count+= i;
                i++;
            }
            Console.WriteLine($"The sum of given range is: {count}");
            Console.ReadLine();
        }
    }
}
