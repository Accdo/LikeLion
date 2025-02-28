using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr_For_Func_Mission
{
    class Program
    {
        static int Add(int _a, int _b)
        {
            return _a + _b;
        }
        static int GetLength(string _str)
        {
            return _str.Length;
        }
        static int GetMax(int _x, int _y, int _z)
        {
            int max = _x;
            if (max < _y)
                max = _y;
            if (max < _z)
                max = _z;

            return max;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("<Q1 배열 요소 출력>");
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(arr[i]);

            //Console.WriteLine("<Q2 배열 요소 합 구하기>");
            //int sum = 0;
            //int[] arr2 = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //    sum += arr2[i];
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("<Q3 최대값 찾기>");
            //int[] arr3 = new int[5] { 3, 8, 15, 6, 2 };
            //int max = arr3[0];
            //for (int i = 1; i < 5; i++)
            //{
            //    if (max < arr3[i])
            //        max = arr3[i];
            //}
            //Console.WriteLine(max);

            //Console.WriteLine("<Q4 1부터 10까지 출력(for문)>");
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine(i);

            //Console.WriteLine("<Q5 짝수만 출력(while문)>");
            //int n = 1;
            //while (n <= 10)
            //{
            //    if (n % 2 == 0)
            //        Console.WriteLine(n);
            //    n++;
            //}

            //Console.WriteLine("<Q6 배열 요소 출력(foreach)>");
            //int[] arr4 = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (int num in arr4)
            //    Console.WriteLine(num);

            //Console.WriteLine("<Q7 두 수의 합을 구하는 함수>");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Add(a, b));

            //Console.WriteLine("<Q8 문자열 길이 반환 함수>");
            //string str = Console.ReadLine();
            //Console.WriteLine(GetLength(str));

            //Console.WriteLine("<Q9 가장 큰 수 반환 함수>");
            //int x, y, z;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //z = int.Parse(Console.ReadLine());
            //Console.WriteLine(GetMax(x,y,z));
        }
    }
}