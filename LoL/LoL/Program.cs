using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL
{
    public class Champion
    {
        public string Name;
        public int Health;
        public int Mana;

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}가 기본 공격을 합니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}가 움직입니다.");
        }

        public virtual void Skill_Q(Champion target)
        {
            Console.WriteLine("아직 스킬을 배우지 않았습니다.");
        }
        public virtual void Skill_W(Champion target)
        {
            Console.WriteLine("아직 스킬을 배우지 않았습니다.");
        }
        public virtual void Skill_E(Champion target)
        {
            Console.WriteLine("아직 스킬을 배우지 않았습니다.");
        }
        public virtual void Skill_R(Champion target)
        {
            Console.WriteLine("아직 스킬을 배우지 않았습니다.");
        }
    }

    public class Khazix : Champion
    {
        public Khazix()
        {
            Name = "카직스";
            Health = 500;
            Mana = 300;
        }

        public override void Skill_Q(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 공포 감지를 시전하였습니다.");
        }
        public override void Skill_W(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 공허의 가시를 시전하였습니다.");
        }
        public override void Skill_E(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 도약을 시전하였습니다.");
        }
        public override void Skill_R(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 공허의 습격을 시전하였습니다.");
        }
    }
    public class Zac : Champion
    {
        public Zac()
        {
            Name = "자크";
            Health = 600;
            Mana = 0;
        }

        public override void Skill_Q(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 탄성 주먹을 시전하였습니다.");
        }
        public override void Skill_W(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 불안정 물질을 시전하였습니다.");
        }
        public override void Skill_E(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 새총 발사를 시전하였습니다.");
        }
        public override void Skill_R(Champion target)
        {
            Console.WriteLine($"{target.Name}에게 바운스!를 시전하였습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>();
            champions.Add(new Khazix());
            champions.Add(new Zac());

            foreach (var champion in champions)
            {
                champion.Attack();
                champion.Move();
                Console.WriteLine(" ");
            }
            Khazix khazix = new Khazix();
            khazix.Skill_E(champions[1]);
            khazix.Skill_W(champions[1]);
            khazix.Skill_Q(champions[1]);
            Console.WriteLine(" ");

            Zac zac = new Zac();
            zac.Skill_R(champions[0]);
        }
    }
}
