using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12_Given_string_is_palindrome_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// To check given string is palindrome or not.
         //palindrome means left to right and right to left both are same example EYE
            Console.Write("Enter your string:\t");
            string a=Console.ReadLine().ToUpper();
            string b = null;
            for(int i=a.Length-1; i>=0; i--)
            {
                b = b + a[i];
            }
            if (a == b)
                Console.WriteLine($"{a} is a palindrome.");
            else
                Console.WriteLine($"{a} is not a palindrome.");
            Console.ReadLine();
        }
    }
}
