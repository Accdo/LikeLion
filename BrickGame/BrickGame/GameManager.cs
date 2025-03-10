using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;

        List<Brick> BrickList = new List<Brick>();

        public void Initialize()
        {
            if(m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }

            if (m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();
            }

            BrickList.Add(new Brick(5, 17));
            BrickList.Add(new Brick(37, 10));
            BrickList.Add(new Brick(52, 13));
            BrickList.Add(new Brick(75, 8));
            BrickList.Add(new Brick(60, 5));

            m_pBall.SetBar(m_pBar);
            m_pBall.SetBrick(BrickList);
        }

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
            for (int i = 0; i < 5; i++)
            {
                BrickList[i].Progress();
            }
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
            for (int i = 0; i < 5; i++)
            {
                BrickList[i].Render();
            }
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
            for (int i = 0; i < 5; i++)
            {
                BrickList[i].Release();
            }
        }
    }
}
