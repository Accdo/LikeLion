using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Brick
    {
        public int Xpos;
        public int Ypos;

        Random rand;

        public Brick(int x, int y)
        {
            Xpos = x;
            Ypos = y;
        }

        public void Initialize()
        {
            rand = new Random();

            Xpos = rand.Next(5, 76);
            Ypos = rand.Next(5, 21);

        }

        public void Progress()
        {

        }
        public void Render()
        {
            Program.gotoxy(Xpos, Ypos);
            Console.Write("■");
        }
        public void Release()
        {
        }
    }
}
