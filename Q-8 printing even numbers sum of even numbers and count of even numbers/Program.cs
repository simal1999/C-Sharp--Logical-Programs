using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_8_printing_even_numbers_sum_of_even_numbers_and_count_of_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {// printing even numbers,sum of even numbers and count of even numbers/
            Console.Write("Enter your range to display even numbers only :\t");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            Console.WriteLine("The list of even numbers are: ");
            for (int i = 0; i <=n; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    count+=1;
                    sum+=i;
                }
            }
            Console.WriteLine($"The number of even numbers in given range are {count}.");
            Console.WriteLine($"The sum of even numbers in given range are {sum}.");
            Console.ReadLine();
        }
    }
}
