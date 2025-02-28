using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study18
{
    //class Person
    //{
    //    private string name;


    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }
    //    public string GetName()
    //    {
    //        return name;
    //    }
    //}

    //class Person
    //{
    //    private string name; //내부변수

    //    public string Name //프로퍼티
    //    {
    //        get { return name; } //Getter
    //        set { name = value; } //Setter
    //    }
    //}

    //class Person
    //{
    //    private int count = 100;

    //    public string Name { get; set; }

    //    public int Count
    //    {
    //        get { return count; }
    //    }
    //    public float Balance { get; private set; }
    //    public void AddBal()
    //    {
    //        Balance += 100;
    //    }

    //}   

    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 50;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.SetName("홍길동");
            //Console.WriteLine(p.GetName());

            //Person p = new Person();
            //p.Name = "홍길동";
            //p.AddBal();
            //Console.WriteLine("이름 : " + p.Name + " Count : " + p.Count + " Balance : " + p.Balance);

            Marin m = new Marin();

            Console.WriteLine("이름 : " + m.Name + ", 미네랄 : " + m.Mineral);
        }
    }
}