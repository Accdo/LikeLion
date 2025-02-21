using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting;
            //greeting = "Hello, World!";

            //Console.WriteLine(greeting);

            //

            //int score = 100;
            //double temperature = 36.6;
            //string city = "Seoul";

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);

            //

            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //

            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi : " + Pi);
            //Console.WriteLine("MaxScore : " + MaxScore);

            //

            int Atk = 16755;
            const int MaxHp = 78103;

            int Critical = 36;
            int Special = 1017;
            int OverPower = 41;
            int Speed = 611;
            int Patience = 22;
            int skillful = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + Atk);
            Console.WriteLine("최대생명력 : " + MaxHp);

            Console.WriteLine("전투 특성");
            Console.WriteLine("치명 : " + Critical);
            Console.WriteLine("특화 : " + Special);
            Console.WriteLine("제압 : " + OverPower);
            Console.WriteLine("신속 : " + Speed);
            Console.WriteLine("인내 : " + Patience);
            Console.WriteLine("숙련 : " + skillful);
        }
    }
}
