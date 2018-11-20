using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 24 / (9 * (Math.Pow(n, 2)) - 12 * n - 5);


            }
            Console.WriteLine("Sum = {0}", s);
            Console.ReadLine();
        }
    }
}
