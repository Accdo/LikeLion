using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public event EventHandler OnDamaged;

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;

            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력 : {Health}");

            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            Character character = (Character)sender;

            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다!" +
                $"현재 체력 : {character.Health}");
        }

        static void Main(string[] args)
        {
            Character hero = new Character("용사", 100);

            hero.OnDamaged += Hero_OnDamaged;
            hero.TakeDamage(30);

            hero.OnDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 구독 취소");
            hero.TakeDamage(20);
        }
    }
}
