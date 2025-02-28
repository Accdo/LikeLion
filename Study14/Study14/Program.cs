using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study14
{
    class Program
    {
        //enum DayOfWeek
        //{
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}

        enum Weapontype
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(Weapontype type)
        {
            switch(type)
            {
                case Weapontype.Sword:
                    Console.WriteLine("검을 선택했습니다.");
                    break;
                case Weapontype.Bow:
                    Console.WriteLine("활을 선택했습니다.");
                    break;
                case Weapontype.Staff:
                    Console.WriteLine("지팡이를 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("잘못 선택했습니다.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine($"Pi: {Math.PI}");
            //Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            //Console.WriteLine($"Power (2^3): {Math.Pow(2,3)}");
            //Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");

            //

            //DayOfWeek today = DayOfWeek.Wednesday;
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);

            ChooseWeapon(Weapontype.Sword);
            ChooseWeapon(Weapontype.Bow);
            ChooseWeapon(Weapontype.Staff);
        }
    }
}
