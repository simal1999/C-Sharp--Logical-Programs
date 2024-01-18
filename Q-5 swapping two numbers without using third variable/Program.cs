using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5_swapping_two_numbers_without_using_third_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {//swapping two numbers by using third variable
            Console.WriteLine("Enter i value:");
            int i=int.Parse(Console.ReadLine());//10 is input
            Console.WriteLine("Enter j value:");
            int j = int.Parse(Console.ReadLine());//5 is input
            i = i + j;//i=10+5=15
            j = i - j;//j=15-5=10
            i = i - j;//i=15-10=5
            Console.WriteLine($"i value is {i}\nj value is {j}.");
            Console.ReadLine();
        }
    }
}
