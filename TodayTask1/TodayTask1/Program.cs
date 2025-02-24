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
            int Hp = 200;
            int Point = 2;

            Random randomObj = new Random();

            string SkillName1 = "";
            int[] Skill1 = new int[2];
            int[] strike = new int[2] { 8, 12 }; // 장검 베기 , 1행동
            int[] shot = new int[2] { 15, 25 }; // 활쏘기 , 한번에 2행동
            int[] magicball = new int[2] { 14, 20 }; // 매직 볼 , 캐스팅 1행동 후 다음턴 발사
            int[] slash = new int[2] { 4, 10 }; // 단검 베기 , 행동 한번더 가능

            int Monster1_Hp = 50;

            Console.WriteLine("엔터를 눌러 게임 시작");
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

            Console.WriteLine("요괴의 탑에 도착했다.\n");
            Console.ReadLine();
            Console.WriteLine("다양한 기술로 탑을 공략하자!");
            Console.ReadLine();
            Console.WriteLine("플레이어 HP : 200");
            Console.ReadLine();

            int random = randomObj.Next(1,4);
            if (random == 1)
            {
                SkillName1 = "장검 베기";
                Skill1 = strike;
            }
            else if (random == 2)
            {
                SkillName1 = "활 쏘기";
                Skill1 = shot;
            }
            else if (random == 3)
            {
                SkillName1 = "매직 볼";
                Skill1 = magicball;
            }
            else if (random == 4)
            {
                SkillName1 = "단검 베기";
                Skill1 = slash;
            }
            Console.WriteLine(SkillName1 +"을(를) 획득했다.");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("요괴의 탑 1층\n");
            Console.ReadLine();
            Console.WriteLine("두억시니가 나타났다.");
            Console.ReadLine();
            while(true)
            {
                Console.WriteLine("플레이어 HP : " + Hp);
                Console.ReadLine();
                Console.WriteLine("두억시니 HP : " + Monster1_Hp);
                Console.ReadLine();
                Console.WriteLine("1. " + SkillName1);
                Console.ReadLine();
                Console.WriteLine(SkillName1 + " 로 공격했다");
                Console.ReadLine();

                int randomDmg = randomObj.Next(Skill1[0], Skill1[1]);
                Monster1_Hp -= randomDmg;

                Console.WriteLine(randomDmg + " 의 데미지를 입혔다.");
                Console.ReadLine();
                Console.WriteLine("두억시니 HP : " + Monster1_Hp);
                Console.ReadLine();

                if (Monster1_Hp <= 0)
                {
                    Console.WriteLine("두억시니가 쓰러졌다.");
                    Console.ReadLine();
                    break;
                } 

            }



            Console.WriteLine("완");
            Console.ReadLine();


        }
    }
}