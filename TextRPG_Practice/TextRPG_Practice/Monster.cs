using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Practice
{
    class Monster
    {
        public INFO m_tMonster;

        Random rand = new Random();

        public void SetDamage(int iAttack, DebuffState debuff) 
        {
            if (rand.Next(1, 101) <= m_tMonster.iMoving)
            {
                Console.WriteLine("플레이어가 회피에 성공하였습니다.");
                return;
            }

            m_tMonster.iHp -= iAttack;
            Console.WriteLine($"몬스터가 {iAttack}의 피해를 입었습니다.");

            if (debuff == DebuffState.Fire)
            {
                if(rand.Next(1,101) <= 30)
                {
                    m_tMonster.iHp -= iAttack;
                    Console.WriteLine($"몬스터가 화상을 입어 추가로 {iAttack}의 피해를 입었습니다.");
                }
            }
            if (debuff == DebuffState.Ice) 
            {
                if (rand.Next(1, 101) <= 30)
                {
                    m_tMonster.iAttack--;
                    Console.WriteLine($"몬스터의 공격력이 감소합니다.");
                }
            }
        }

        public void SetMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 : " + m_tMonster.iAttack
                 + "\t회피율 : " + m_tMonster.iMoving);
        }

        public Monster() { }
        ~Monster() { }
    }
}
