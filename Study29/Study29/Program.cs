using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study29
{
    class Program
    {
        interface IAnimal
        {
            void MakeSound();
        }

        class Dog : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("멍멍!");
            }
        }

        class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("야옹!");
            }
        }

        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.MakeSound();

            IAnimal cat = new Cat();
            cat.MakeSound();
        }
    }
}
