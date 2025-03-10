using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();

            mainGame.Start();
            mainGame.Update();
        }
    }
}
