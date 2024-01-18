using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping_two__numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {// swapping of to numbers.
            Console.WriteLine("Enter i value:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter j value:");
            int j=int.Parse(Console.ReadLine());
            int a = i;
            i = j;
            j = a;
            Console.WriteLine($"i value is : {i}");
            Console.WriteLine($"j value is : {j}");
            Console.ReadLine();

        }
    }
}
