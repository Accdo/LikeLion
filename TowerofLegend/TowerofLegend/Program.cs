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

            public int Moving;
            public int Heal;
            public int HealCoolTime;

            public Golem(string _name, int _hp, int minAtk, int maxAtk)
            {
                name = _name;
                Hp = _hp;
                Attack[0] = minAtk;
                Attack[1] = maxAtk;
            }
            public Golem(string _name, int _hp, int minAtk, int maxAtk, 
                int _move , int _heal, int _healcooltime)
            {
                name = _name;
                Hp = _hp;
                Attack[0] = minAtk;
                Attack[1] = maxAtk;

                Moving = _move;
                Heal = _heal;
                HealCoolTime = _healcooltime;
            }

            public void Healing()
            {
                Hp += Heal;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random(); // 난수
            int Miss = 0; // 회피
            int PlusAtk = 0; // 회피

            int CurrentLevel = 0;

            int hp = 200;
            int mp = 2;
            int power = 10;

            int PlusAtkPercent = 10;
            int PlusAtkNumber = 1;
            int Moving = 10;

            int[] Slash = new int[2] { 160, 240 };
            int[] MoonSlash = new int[2] { 140, 220 };
            int[] LSum = new int[2] { 300, 500 };

            int input;
            bool isAlive = true;

            int damage = 0; // 최종 데미지 계싼

            // 베기, 막기(회피 up)

            // 1 초승달 베기(회피+5)  == 아이언 골렘
            // 2 집중(추공 횟수 증가 1) == 브론즈 골렘
            // 3 일도양단(전설의 카타나를 장착, 공+10&추공+2) == 골드 골렘
            // 4 오의:벽력일섬 == 에메랄드 골렘
            string skill_1 = "X";
            string skill_2 = "X";
            string skill_3 = "X";
            string skill_4 = "X";

            // 패시브
            // 크리티컬 확률, 추가 공격 확률, 추가 공격 횟수, 출혈계수, 회피율
            Golem[] stoneGolem = new Golem[7];

            stoneGolem[0] = new Golem("돌 골렘", 50, 10, 20);
            stoneGolem[1] = new Golem("아이언 골렘", 70, 15, 25);
            stoneGolem[2] = new Golem("브론즈 골렘", 150, 5, 40, 10, 100, 3); // 회피 10, 3턴당 100 회복

            stoneGolem[3] = new Golem("실버 골렘", 120, 25, 35, 5, 20, 1); // 회피 5, 매턴 20 회복 
            stoneGolem[4] = new Golem("골드 골렘", 300, 40, 50, 30, 150, 4); // 회피 30, 4턴당 150 회복
            stoneGolem[5] = new Golem("에메랄드 골렘", 500, 10, 100, 20, 50, 2); // , 2턴당 회복

            stoneGolem[6] = new Golem("다이아 골렘", 1000, 50, 100, 15, 40, 1); // , 매 턴 회복

            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                           전설의 탑                            |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine(" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Thread.Sleep(10500);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 층 : {CurrentLevel} 층 \n");
                Console.WriteLine($"현재 상태 : 체력 {hp} | 마나 {mp} | 공격력 {power} \n");
                Console.WriteLine($"현재 상태 : 추가공격 확률 {PlusAtkPercent} " +
                    $"| 추가공격 횟수 {PlusAtkNumber} | 회피율 {Moving}");

                Console.WriteLine("\n1. 탑 오르기 ");
                Console.WriteLine("2. 게임 종료 ");
                Console.WriteLine("입력 : ");

                input = int.Parse(Console.ReadLine());

                int stoneIndex = CurrentLevel;
                int stoneHealTurn = 0;

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("탑을 오릅니다...\n");
                    Thread.Sleep(1000);
                    Console.WriteLine($"현재 층 : {++CurrentLevel}");
                    Console.ReadLine();

                    Console.WriteLine($"{stoneGolem[stoneIndex].name}이 나타났다.\n");
                    Console.ReadLine();
                    Console.Clear();

                    int currentMp;
                    int currentMove = Moving;

                    while (stoneGolem[stoneIndex].Hp > 0)
                    {
                        currentMp = mp;

                        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n");
                        Console.WriteLine($"플레이어 상태 : 체력 {hp} - 마나 {currentMp} - 공격력 {power} \n");
                        Console.WriteLine($"플레이어 상태 : 추가공격 확률 {PlusAtkPercent} " +
                            $"- 추가공격 횟수 {PlusAtkNumber} - 회피율 {currentMove} \n");

                        Console.WriteLine("vs \n");

                        Console.WriteLine($"{stoneGolem[stoneIndex].name} : HP {stoneGolem[stoneIndex].Hp}" +
                            $" - 공격력 {stoneGolem[stoneIndex].Attack[0]} ~ {stoneGolem[stoneIndex].Attack[1]} \n");
                        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ\n");
                        Console.ReadLine();

                        while (currentMp > 0)
                        {
                            Console.WriteLine($"플레이어 턴 (남은 턴 : {currentMp}턴 \n");

                            Console.WriteLine($"1. 베기 2. 회피 3. {skill_1} 4. {skill_2} 5. {skill_3} 6. {skill_4} \n");

                            int choose = int.Parse(Console.ReadLine());

                            switch (choose)
                            {
                                case 1:
                                    Miss = rand.Next(1, 100);
                                    if (Miss > stoneGolem[stoneIndex].Moving)
                                    {
                                        damage = rand.Next(Slash[0] * power / 100, Slash[1] * power / 100);
                                        stoneGolem[stoneIndex].Hp -= damage;

                                        Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                        Console.ReadLine();
                                        Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("골렘이 회피하였습니다. \n");
                                        Console.ReadLine();
                                    }

                                    for(int i = 0; i < PlusAtkNumber; i++)
                                    {
                                        PlusAtk = rand.Next(1, 100);
                                        if (PlusAtk <= PlusAtkPercent)
                                        {
                                            Console.WriteLine("추가 공격 성공! \n");
                                            Console.ReadLine();

                                            damage = rand.Next(Slash[0] * power / 100, Slash[1] * power / 100);
                                            stoneGolem[stoneIndex].Hp -= damage;

                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                            Console.ReadLine();
                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                            Console.ReadLine();
                                        }
                                    }

                                    

                                    currentMp--;
                                    break;
                                case 2:
                                    currentMove += 10;
                                    Console.WriteLine("플레이어의 회피율이 10 올랐습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"플레이어의 회피율 {currentMove} \n");
                                    Console.ReadLine();
                                    currentMp--;
                                    break;
                                case 3:
                                    if (skill_1 == "X")
                                    {
                                        Console.WriteLine("스킬이 존재하지 않습니다.\n");
                                        break;
                                    }

                                    currentMove += 5;
                                    Console.WriteLine("플레이어의 회피율이 5 올랐습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"플레이어의 회피율 {currentMove} \n");
                                    Console.ReadLine();

                                    Miss = rand.Next(1, 100);
                                    if (Miss > stoneGolem[stoneIndex].Moving)
                                    {
                                        damage = rand.Next(MoonSlash[0] * power / 100, MoonSlash[1] * power / 100);
                                        stoneGolem[stoneIndex].Hp -= damage;

                                        Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                        Console.ReadLine();
                                        Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("골렘이 회피하였습니다. \n");
                                        Console.ReadLine();
                                    }

                                    for (int i = 0; i < PlusAtkNumber; i++)
                                    {
                                        PlusAtk = rand.Next(1, 100);
                                        if (PlusAtk <= PlusAtkPercent)
                                        {
                                            Console.WriteLine("추가 공격 성공! \n");
                                            Console.ReadLine();

                                            damage = rand.Next(MoonSlash[0] * power / 100, MoonSlash[1] * power / 100);
                                            stoneGolem[stoneIndex].Hp -= damage;

                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                            Console.ReadLine();
                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                            Console.ReadLine();
                                        }
                                    }

                                        

                                    currentMp--;
                                    break;
                                case 4:
                                    if (skill_1 == "X")
                                    {
                                        Console.WriteLine("스킬이 존재하지 않습니다.\n");
                                        break;
                                    }

                                    PlusAtkNumber += 1;
                                    Console.WriteLine("집중합니다... \n");
                                    Console.ReadLine();
                                    Console.WriteLine("플레이어의 추가공격 횟수가 1 올랐습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"플레이어의 추가공격 횟수 {PlusAtkNumber} \n");
                                    Console.ReadLine();
                                    if(currentMp >= 2)
                                        currentMp-=2;
                                    break;
                                case 5:
                                    if (skill_1 == "X")
                                    {
                                        Console.WriteLine("스킬이 존재하지 않습니다.\n");
                                        break;
                                    }

                                    power += 10;
                                    PlusAtkNumber += 2;
                                    Console.WriteLine("명도를 장착합니다... \n");
                                    Console.ReadLine();
                                    Console.WriteLine("플레이어의 공격력과 추가공격 횟수가 올라갑니다. \n");
                                    Console.ReadLine();
                                    if (currentMp >= 3)
                                        currentMp -= 3;
                                    break;

                                case 6:
                                    if (skill_1 == "X")
                                    {
                                        Console.WriteLine("스킬이 존재하지 않습니다.\n");
                                        break;
                                    }
                                    Console.WriteLine("벽력일섬으로 적을 벱니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine("이 공격은 회피를 무시합니다. \n");
                                    Console.ReadLine();

                                    damage = rand.Next(LSum[0] * power / 100, LSum[1] * power / 100);
                                    stoneGolem[stoneIndex].Hp -= damage;

                                    Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                    Console.ReadLine();
                                    Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                    Console.ReadLine();

                                    for (int i = 0; i < PlusAtkNumber; i++)
                                    {
                                        PlusAtk = rand.Next(1, 100);
                                        if (PlusAtk <= PlusAtkPercent)
                                        {
                                            Console.WriteLine("추가 공격 성공! \n");
                                            Console.ReadLine();

                                            damage = rand.Next(LSum[0] * power / 100, LSum[1] * power / 100);
                                            stoneGolem[stoneIndex].Hp -= damage;

                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}이 {damage}의 피해를 입었습니다. \n");
                                            Console.ReadLine();
                                            Console.WriteLine($"{stoneGolem[stoneIndex].name}의 Hp {stoneGolem[stoneIndex].Hp} \n");
                                            Console.ReadLine();
                                        }
                                    }



                                    if (currentMp >= 4)
                                        currentMp -= 4;
                                    break;
                                default:
                                    Console.WriteLine("다시 입력하세요. \n");
                                    Console.ReadLine();
                                    break;
                            }

                            if (stoneGolem[stoneIndex].Hp <= 0) break;
                        }
                        if (stoneGolem[stoneIndex].Hp <= 0) break;

                        Console.WriteLine($"{stoneGolem[stoneIndex].name} 턴 \n");
                        Console.ReadLine();

                        if(stoneIndex >= 2)
                        {
                            stoneHealTurn++;
                            if (stoneGolem[stoneIndex].HealCoolTime <= stoneHealTurn)
                            {
                                Console.WriteLine($"골렘이 {stoneGolem[stoneIndex].Heal} 만큼 회복합니다. \n");
                                Console.ReadLine();

                                stoneGolem[stoneIndex].Healing();

                                Console.WriteLine($"골렘의 HP : {stoneGolem[stoneIndex].Hp} \n");
                                Console.ReadLine();

                                stoneHealTurn = 0;
                            }
                        }

                        Console.WriteLine($"{stoneGolem[stoneIndex].name}이 펀치를 날립니다. \n");
                        Console.ReadLine();
                        Miss = rand.Next(1, 100);
                        if(Miss > currentMove)
                        {
                            damage = rand.Next(stoneGolem[stoneIndex].Attack[0], stoneGolem[stoneIndex].Attack[1]);
                            hp -= damage;
                            Console.WriteLine($"플레이어가 {damage} 의 데미지를 입었습니다.\n");
                            Console.ReadLine();
                            Console.WriteLine($"플레이어의 Hp {hp} \n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("플레이어가 회피하였습니다. \n");
                            Console.ReadLine();
                        }

                    }

                    Console.WriteLine($"{stoneGolem[stoneIndex].name}이 쓰러졌습니다.\n");
                    Console.ReadLine();

                    if(stoneIndex == 1)
                    {
                        Console.WriteLine("새로운 스킬을 획득하였습니다. \n");
                        Console.ReadLine();
                        Console.WriteLine("새로운 스킬 : 초승달 베기 \n");
                        Console.ReadLine();

                        skill_1 = "초승달 베기";

                        power += 10;
                        PlusAtkPercent += 10;
                        Console.WriteLine("추가로 플레이어의 스텟이 올라갑니다... \n");
                        Console.ReadLine();
                    }
                    else if (stoneIndex == 2)
                    {
                        Console.WriteLine("새로운 스킬을 획득하였습니다. \n");
                        Console.ReadLine();
                        Console.WriteLine("새로운 스킬 - 집중 \n");
                        Console.ReadLine();

                        skill_2 = "집중";

                        Console.WriteLine("최대 마나가 오릅니다. \n");
                        Console.ReadLine();
                        Console.WriteLine($"마나 : {++mp}\n");
                        Console.ReadLine();

                        PlusAtkPercent += 10;
                        Console.WriteLine("추가로 플레이어의 스텟이 올라갑니다... \n");
                        Console.ReadLine();
                    }
                    else if (stoneIndex == 4)
                    {
                        Console.WriteLine("새로운 스킬을 획득하였습니다. \n");
                        Console.ReadLine();
                        Console.WriteLine("새로운 스킬 - 일도양단 \n");
                        Console.ReadLine();

                        skill_3 = "일도양단";

                        Console.WriteLine("최대 마나가 오릅니다. \n");
                        Console.ReadLine();
                        Console.WriteLine($"마나 : {++mp}\n");
                        Console.ReadLine();

                        power += 10;
                        PlusAtkPercent += 10;
                        Console.WriteLine("추가로 플레이어의 스텟이 올라갑니다... \n");
                        Console.ReadLine();
                    }
                    else if (stoneIndex == 5)
                    {
                        Console.WriteLine("새로운 스킬을 획득하였습니다. \n");
                        Console.ReadLine();
                        Console.WriteLine("새로운 스킬 - 오의:벽력일섬 \n");
                        Console.ReadLine();

                        skill_4 = "오의:벽력일섬";

                        Console.WriteLine("최대 마나가 오릅니다. \n");
                        Console.ReadLine();
                        Console.WriteLine($"마나 : {++mp}\n");
                        Console.ReadLine();

                        PlusAtkPercent += 10;
                        Console.WriteLine("추가로 플레이어의 스텟이 올라갑니다... \n");
                        Console.ReadLine();
                    }

                    Console.WriteLine("골렘의 기운으로 체력을 회복합니다. \n");
                    Console.ReadLine();
                    hp += 50;

                    Console.WriteLine($"다음 층으로 올라갑니다. \n");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
