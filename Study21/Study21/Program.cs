using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study21
{
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog();

            //Dog myDog = (Dog)myAnimal;

            Dog myDog = myAnimal as Dog;

            if(myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("실패!");
            }


        }
    }
}
