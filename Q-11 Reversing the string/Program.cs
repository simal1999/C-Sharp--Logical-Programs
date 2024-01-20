using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11_Reversing_the_string
{
    internal class Program
    {
        static void Main(string[] args)
        {// reversing the string
         // string has indexing value
            Console.Write("Enter the string to reverse:\t");
            string a=Console.ReadLine().ToUpper();
            for(int i=a.Length-1; i>=0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadLine();
        }
    }
}
