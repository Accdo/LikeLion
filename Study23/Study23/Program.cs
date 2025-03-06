using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study23
{
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모클래스의 메시지");
        }
    }

    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식클래스의 메시지");
            base.ShowMessage();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();

            child.ShowMessage();
        }
    }
}
