using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6_number_pattern_1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*number pattern output like
            -----------------------------------
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5*/
            Console.Write("Enter number :\t");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)// row index for loop.
            {
                for(int j=1;j<=i;j++)// column index for loop.
                {
                    Console.Write(i + " ");
                }
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}
