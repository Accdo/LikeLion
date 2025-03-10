using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class MainGame
    {
        public Player player = null;

        public Field field = null;

        int input;

        public void Start()
        {
            player = new Player();
            player.SelectJob();

        }
        public void Update()
        {
            while (true)
            {
                Console.Clear();
                player.Render();

                Console.WriteLine("1. 사냥터 2. 종료 : ");
                input = int.Parse(Console.ReadLine());

                if (input != 1)
                    break;

                if (field == null)
                {
                    field = new Field();
                    field.SetPlayer(ref player);
                }

                field.Update();
            }
        }
    }
}
