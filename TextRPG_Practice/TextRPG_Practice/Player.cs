using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Practice
{
    public class MagicSkill
    {
        public string skillName;
        public int debuff;

        public MagicSkill(string _skillName, int _debuff)
        {
            this.skillName = _skillName;
            this.debuff = _debuff;
        }
    }

    public class Player
    {
        public INFO m_tInfo;

        public MagicSkill magicSkills;

        Random rand = new Random();

        public void SetDamage(int iAttack) 
        { 
            if(rand.Next(1,101) <= m_tInfo.iMoving)
            {
                Console.WriteLine("플레이어가 회피에 성공하였습니다.");
                return;
            }

            m_tInfo.iHp -= iAttack;
            Console.WriteLine($"플레이어가 {iAttack}의 피해를 입었습니다.");
        }
        public INFO GetInfo() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        public void SelectSkill()
        {
            m_tInfo = new INFO();

            Console.WriteLine("<스킬을 선택하세요>");
            Console.WriteLine("1. 파이어 볼 : 불덩이를 던져 공격력x1.0 의 피해를 입히고 30% 확률로 화상을 부여함");
            Console.WriteLine("2. 아이스 스피어 : 얼음 창을 날려 공격력x1.0 의 피해를 입히고 30% 확률로 상대를 공감");
            Console.WriteLine("3. 소프트 윈드 : 소풍을 일으켜 공격력 1.0의 피해를 입히고 회피율 10% 올림 ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    magicSkills = new MagicSkill("파이어 볼", 1);
                    break;
                case 2:
                    magicSkills = new MagicSkill("아이스 스피어", 2);
                    break;
                case 3:
                    magicSkills = new MagicSkill("소프트 윈드", 3);
                    break;
            }
            m_tInfo.iHp = 100;
            m_tInfo.iAttack = 10;
            m_tInfo.iMoving = 10;
        }
        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("직업 이름 : 마법사");
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack
                 + "\t회피율 : " + m_tInfo.iMoving);
        }

        public Player() { }
        ~Player() { }
    }
}
