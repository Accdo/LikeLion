using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Player
    {
        public INFO p_Info;

        int input;

        public void SetHealth(int _damage) { p_Info.Hp -= _damage; }

        public void SetStat(string _name, int _hp, int power)
        {
            p_Info = new INFO();

            p_Info.Name = _name;
            p_Info.Hp = _hp;
            p_Info.Power = power;
        }

        public void SelectJob()
        {
            Console.WriteLine("직업을 선택하세요 (1.기사 2.마법사 3.도적)");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    SetStat("기사",100,10);
                    break;
                case 2:
                    SetStat("마법사", 90, 15);
                    break;
                case 3:
                    SetStat("도적", 80, 12);
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("======================");
            Console.WriteLine("직업 이름 : " + p_Info.Name);
            Console.WriteLine("체력 : " + p_Info.Hp + "\t공격력 : " + p_Info.Power);
        }
    }
}
