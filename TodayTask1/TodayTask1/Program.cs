using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("게임 시작");
            Console.ReadLine();
            Console.Clear();

            string Nemo = "□□□□□□□□□□";

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(Nemo);
                Thread.Sleep(100);
                Console.Clear();

                if (i > 9) continue;
                
                Nemo = Nemo.Remove(9);
                Nemo = Nemo.Insert(i, "■");
            }

            Console.WriteLine("108요괴가 세상에 풀렸다.\n");
            Thread.Sleep(1100);
            Console.WriteLine("도술을 활용하여 요괴들을 물리쳐라.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("태초 마을에 도착했다.");
            Console.ReadLine();
            Console.WriteLine("태초 마을 입구에서 첫 번쨰 요괴 두억시니가 날뛰고 있다.");
            Console.ReadLine();
            Console.WriteLine("두억시니를 향해 달려가서 전투를 시작한다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("플레이어 HP : 1000");
            Console.ReadLine();
            Console.WriteLine("두억시니 HP : 100");
            Console.WriteLine("두억시니 DMG : 10 \n");
            Thread.Sleep(1100);
            Console.WriteLine("두억시니 패시브 : 0.000001% 확률로 크리티컬이 발동하여 기본 데미지의 100배를 줍니다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("플레이어가 [바람 도술 : 풍류파] 를 시전하였다.\n");
            Thread.Sleep(1100);
            Console.WriteLine("두억시니가 99 의 피해를 입었다.");
            Console.ReadLine();
            Console.WriteLine("두억시니 HP : 1");
            Console.ReadLine();
            Console.WriteLine("두억시니가 [박치기] 를 시전하였다.\n");
            Thread.Sleep(1100);
            Console.WriteLine("삐빔!");
            Console.ReadLine();
            Console.WriteLine("두억시니의 [박치기] 가 0.000001% 확률로 크리티컬이 발동하였다.");
            Console.ReadLine();
            Console.WriteLine("플레이어가 1000 의 피해를 입었다.");
            Console.ReadLine();
            Console.WriteLine("플레이어 HP : 0");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그렇게 세상은 멸망했다.");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.ReadLine();




        }
    }
}
