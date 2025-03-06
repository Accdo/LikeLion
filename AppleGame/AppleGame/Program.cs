using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] AppleDeploy = new int[7,7];

            Random rand = new Random();

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    AppleDeploy[i, j] = rand.Next(1,10);
                    Console.Write(AppleDeploy[i, j] + "  ");
                }
                Console.Write("\n\n");
            }


        }
    }
}
