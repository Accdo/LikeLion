using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TowerofLegend
{
    class Program
    {
        public class Golem
        {
            public string name;
            public int Hp;
            public int[] Attack = new int[2];

            public Golem(string _name, int _hp, int minAtk, int maxAtk)
            {
                name = _name;
                Hp = _hp;
                Attack[0] = minAtk;
                Attack[1] = maxAtk;
            }

            public void Heal(int h)
            {
                Hp += h;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random(); // 난수
            int Miss = 0; // 회피

            int CurrentLevel = 0;

            int hp = 200;
            int mp = 2;
            int power = 10;

            int Critical = 10;
            int PlusAtkPercent = 10;
            int PlusAtkNumber = 1;
            int Bleeding = 2;
            int Moving = 10;

            int[] Slash = new int[2] { 160, 240 };

            int input;
            bool isAlive = true;

            int damage = 0;

            // 베기, 집중(회피 up)
            // 연속 베기, 일섬
            // 급소 찌르기(출혈), 초승달 베기(회피)
            // 2표식 부여(적에게 추가공격 횟수 증폭), 2연막탄(회피증폭)
            // 3수라화(변신, hp감소&모든 스텟 증폭), 3일도양단(전설의 카타나를 장착, 공&크리&추공)
            // 4오의:수라난무, 4오의:벽력일섬


            // 패시브
            // 크리티컬 확률, 추가 공격 확률, 추가 공격 횟수, 출혈계수, 회피율

            Golem stoneGolem = new Golem("돌 골렘", 50, 10, 20);
            Golem ironGolem = new Golem("아이언 골렘", 70, 15, 25);
            Golem bronzeGolem = new Golem("브론즈 골렘", 150, 5, 40); // 3턴당 회복

            Golem silverGolem = new Golem("실버 골렘", 120, 25, 35);
            Golem goldGolem = new Golem("골드 골렘", 300, 40, 50); // 회피, 4턴당 회복
            Golem emeraldGolem = new Golem("에메랄드 골렘", 500, 10, 100); // 반격, 2턴당 회복

            Console.WriteLine(" < 전설의 탑 > ");
            Thread.Sleep(500);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 층 : {CurrentLevel} 층");
                Console.WriteLine($"현재 상태 : 체력 {hp} | 마나 {mp} | 공격력 {power}");
                Console.WriteLine($"현재 상태 : 크리티컬 {Critical} | 추가공격 확률 {PlusAtkPercent} " +
                    $"| 추가공격 횟수 {PlusAtkNumber} | 출혈 {Bleeding} | 회피율 {Moving}");

                Console.WriteLine("\n1. 탑 오르기 ");
                Console.WriteLine("2. 게임 종료 ");
                Console.WriteLine("입력 : ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("탑을 오릅니다...\n");
                    Thread.Sleep(1000);
                    Console.WriteLine($"현재 층 : {++CurrentLevel}");
                    Console.ReadLine();

                    Console.WriteLine($"{stoneGolem.name}이 나타났다.\n");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"{stoneGolem.name} HP {stoneGolem.Hp} ");
                    Console.ReadLine();

                    while(stoneGolem.Hp > 0)
                    {
                        while (mp > 0)
                        {
                            Console.WriteLine("플레이어 턴 \n");
                            Console.WriteLine("1. 베기 2. 회피 \n");

                            int choose = int.Parse(Console.ReadLine());

                            switch (choose)
                            {
                                case 1:
                                    damage = rand.Next(Slash[0]*power / 100, Slash[1]*power / 100);
                                    stoneGolem.Hp -= damage;

                                    Console.WriteLine($"{stoneGolem.name}이 {damage}의 피해를 입었습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"{stoneGolem.name}의 Hp {stoneGolem.Hp} \n");
                                    Console.ReadLine();
                                    mp--;
                                    break;
                                case 2:
                                    Moving += 10;
                                    Console.WriteLine("플레이어의 회피율이 10 올랐습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"플레이어의 회피율 {Moving} \n");
                                    Console.ReadLine();
                                    mp--;
                                    break;
                                default:
                                    Console.WriteLine("다시 입력하세요. \n");
                                    Console.ReadLine();
                                    break;
                            }

                            if (stoneGolem.Hp <= 0) break;
                        }

                        Console.WriteLine($"{stoneGolem.name} 턴 \n");
                        Console.ReadLine();
                        Console.WriteLine($"{stoneGolem.name}이 펀치를 날립니다. \n");
                        Console.ReadLine();
                        Miss = rand.Next(1, 100);
                        if(Miss > Moving)
                        {
                            damage = rand.Next(stoneGolem.Attack[0], stoneGolem.Attack[1]);
                            hp -= damage;
                            Console.WriteLine($"플레이어가 {damage} 의 데미지를 입었습니다.\n");
                            Console.ReadLine();
                            Console.WriteLine($"플레이어의 Hp {hp} \n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("플레이어가 회피하였습니다. \n");
                        }


                            mp += 2;
                    }

                    Console.WriteLine($"{stoneGolem.name}이 쓰러졌습니다.\n");
                    Console.ReadLine();
                    Console.WriteLine($"다음 층으로 올라갑니다. \n");
                    Console.ReadLine();
                    CurrentLevel++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
