using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_9_list_of_odd_numbers_sum_and_count_of_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {// printing odd numbers,sum of odd numbers and count of odd numbers
            Console.Write("Enter your range to display odd numbers only :\t");
            
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            Console.WriteLine("The list of odd numbers are: ");
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count ++;
                    sum += i;
                }
            }
            Console.WriteLine($"The number of odd numbers in given range are {count}.");
            Console.WriteLine($"The sum of odd numbers in given range are {sum}.");
            Console.ReadLine();
        }
    }
}
