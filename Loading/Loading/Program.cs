using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nemo = "□□□□□□□□□□";

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(Nemo);
                Thread.Sleep(1500);
                Console.Clear();
                Nemo = Nemo.Remove(9);
                Nemo = Nemo.Insert(i, "■");
            }
        }
    }
}
