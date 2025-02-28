using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study16
{
    struct Score
    {
        public string name;

        public int Kor;
        public int Eng;
        public int Math;

        public void SetInformation(string n, int k, int e, int m)
        {
            name = n;
            Kor = k;
            Eng = e;
            Math = m;
        }
        public void Print()
        {
            Console.WriteLine($"{name}    {Kor}    {Eng}    {Math}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Score[] scores = new Score[3];

            scores[0].SetInformation("홍길동", 99, 80, 70);
            scores[1].SetInformation("홍길란", 90, 10, 20);
            scores[2].SetInformation("홍길순", 20, 55, 70);

            Console.WriteLine("이름      국어  영어  수학");
            foreach(var score in scores)
            {
                score.Print();
            }    
        }
    }
}
