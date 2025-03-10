using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Field
    {
        public Player Fplayer;
        public Monster Fmonster;

        int input;
        public void SetPlayer(ref Player pPlayer) { Fplayer = pPlayer; }

        public void Update()
        {
            while(true)
            {
                ShowMap();

                input = int.Parse(Console.ReadLine());

                if (input < 4 && input > 0)
                {
                    Fmonster = new Monster();

                    switch (input)
                    {
                        case 1:
                            Fmonster.SetMonster("초보몹", 50, 5);
                            break;
                        case 2:
                            Fmonster.SetMonster("중수몹", 70, 7);
                            break;
                        case 3:
                            Fmonster.SetMonster("고수몹", 70, 7);
                            break;
                    }
                }
                else
                {
                    break;
                }

                Fight();
            }
        }

        public void ShowMap()
        {
            Console.Clear();
            Fplayer.Render();

            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 뒤로가기");
            Console.WriteLine("======================");
            Console.WriteLine("맵을 선택하세요 :");

        }

        public void Fight()
        {
            while(true)
            {
                Console.Clear();
                Fplayer.Render();
                Fmonster.Render();

                Console.WriteLine("1. 공격 2. 도망 : ");
                input = int.Parse(Console.ReadLine());

                if (input != 1)
                    break;

                Fplayer.SetHealth(Fmonster.m_Info.Power);
                Fmonster.SetHealth(Fplayer.p_Info.Power);

                if (Fplayer.p_Info.Hp <= 0)
                {
                    Fplayer.p_Info.Hp = 100;
                    break;
                }
                else if(Fmonster.m_Info.Hp <= 0)
                {
                    break;
                }
            }
        }
    }
}
