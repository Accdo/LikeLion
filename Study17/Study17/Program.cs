using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Study17
{
    class Marin
    {
        public string name;
        public int mineral;

        public Marin()
        {
            this.name = "마린";
            this.mineral = 50;
        }

        public Marin(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name} , 미네랄 : {mineral}");
        }
    }

    class Barracks
    {
        public string name;
        public int mineral;

        public Barracks()
        {
            this.name = "배럭";
            this.mineral = 150;
        }
        public Barracks(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name} , 미네랄 : {mineral}");
        }
    }

    class Mineral
    {
        public int MineralCount;
        public int num;
        
        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"미네랄 개수 : {MineralCount}");
        }
    }

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구 수 {charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 10;
            Game.ShowInfo();

            Marin m1 = new Marin();
            Marin m2 = new Marin("SCV", 50);
            Barracks barracks = new Barracks();

            Mineral[] mineral = new Mineral[7];

            for(int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            m1.ShowInfo();
            m2.ShowInfo();
            barracks.ShowInfo();

        }
    }
}
