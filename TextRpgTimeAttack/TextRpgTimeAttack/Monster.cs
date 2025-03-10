using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Monster
    {
        public INFO m_Info;
        public void SetHealth(int _damage) { m_Info.Hp -= _damage; }

        public void SetMonster(string _name, int _hp, int power)
        {
            m_Info = new INFO();

            m_Info.Name = _name;
            m_Info.Hp = _hp;
            m_Info.Power = power;
        }

        public void Render()
        {
            Console.WriteLine("======================");
            Console.WriteLine("몬스터 이름 : " + m_Info.Name);
            Console.WriteLine("체력 : " + m_Info.Hp + "\t공격력 : " + m_Info.Power);
        }
    }
}
