using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Study20
{
    class Warrior
    {
        public string Name;
        public int Score;
        public int Strenth;

        public Warrior(string name, int score, int strenth)
        {
            Name = name;
            Score = score;
            Strenth = strenth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior("홍길동", 100, 80);
            //Console.WriteLine($"이름 : {warrior.Name} - 점수 : {warrior.Score} - 공격력 : {warrior.Strenth}");

            //

            //int num = 0;
            //try
            //{
            //    Console.WriteLine("정수를 입력하시오.");
            //    num = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"올바른 숫자를 입력하세요! : {ex.Message}");
            //    Environment.Exit(0);
            //}
            //finally
            //{
            //    Console.WriteLine("변환 성공! : " + num);
            //}

            //

            //List<string> Fruit_List = new List<string> { "사과", "바나나", "포도" };
            //Queue<string> Work_Queue = new Queue<string>();
            //Work_Queue.Enqueue("첫 번째 작업");
            //Work_Queue.Enqueue("두 번째 작업");
            //Work_Queue.Enqueue("세 번째 작업");
            //Stack<int> Num_Stack = new Stack<int>();
            //Num_Stack.Push(10);
            //Num_Stack.Push(20);
            //Num_Stack.Push(30);

            //Console.WriteLine($"과일 리스트 : {Fruit_List[0]} {Fruit_List[1]} {Fruit_List[2]}");
            //Console.Write($"작업 큐 : ");
            //while (Work_Queue.Count > 0)
            //{
            //    Console.Write(Work_Queue.Dequeue());
            //    Console.Write(" ");
            //}
            //Console.Write($"\n정수 스택 : ");
            //while (Num_Stack.Count > 0)
            //{
            //    Console.Write(Num_Stack.Pop());
            //    Console.Write(" ");
            //}

            //

            //string str = Console.ReadLine();
            //str = str.ToUpper();
            //str = str.Replace("#", "Sharp");
            //Console.WriteLine("문자열 길이 : " + str.Length);
            //Console.WriteLine("결과 : " + str);

            //

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = 0;

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.Write("짝수 : ");
            foreach (var num in evenNumbers)
            {
                Console.Write(num);
                Console.Write(" ");
            }

            var sumNumbers = from number in numbers select number;
            foreach (var num in sumNumbers)
            {
                result += num;
            }
            Console.Write("\n모든 숫자의 합 : " + result);
        }
    }
}
