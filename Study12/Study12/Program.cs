using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study12
{
    class Program
    {
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            return total;
        }

        static int Factorial(int n)
        {
            if(n <= 1)
                return 1;


            return n * Factorial(n-1);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1,2,3,4));

            Console.WriteLine(Factorial(5));
        }
    }
}
