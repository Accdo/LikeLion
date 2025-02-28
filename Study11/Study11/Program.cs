using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study11
{
    class Program
    {
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static int GetNumber()
        {
            return 42;
        }

        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        static void Divide(int a, int b, out int quotientm, out int remainder)
        {
            quotientm = a / b;

            remainder = a % b;
        }

        static void Increase(ref int num)
        {
            num += 10;
        }

        static void Main(string[] args)
        {
            //PrintHello();
            //PrintMessage("반갑습니다.");

            //int num = GetNumber();
            //Console.WriteLine(num);

            //Greet();
            //Greet("철수");

            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫 : {q}, 나머지 : {r}");

            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);
        }
    }
}
