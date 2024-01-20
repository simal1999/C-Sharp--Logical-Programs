using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14_Checking_given_number_is_palindrome_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// Checking given number is palindrome or not
            Console.Write("Enter your number to check palindrome or not:\t");
            int n=int.Parse(Console.ReadLine());
            int m = n;
            int rem ,rev= 0;
            //int rev, rem = 0;
            while(n!=0)
            {
                rem = n % 10;
                rev = (rev* 10) + rem;
                n = n / 10;
            }
            if(rev==m)
            {
                Console.Write($"{m} is palindrome number.");
            }
            else
            {
                Console.Write($"{m} is not palindrome number.");
            }
            Console.ReadLine();
        }
    }
}
