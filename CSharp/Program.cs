using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fish = new Fish();
            Console.WriteLine(fish.Breathe());
            Console.WriteLine(fish.Eat());
            Console.WriteLine(fish.Sleep());
            //Console.WriteLine(fish.Swim());
            Fish fish2 = new Fish();
            Console.WriteLine(fish2.Breathe());
            Console.WriteLine(fish2.Eat());
            Console.WriteLine(fish2.Sleep());
            Console.WriteLine(fish2.Swim());
        }
    }

    class Animal
    {
        public virtual string Breathe() { return "Animal::Breathe"; }
        public virtual string Eat() { return "Animal::Eat"; }
        public virtual string Sleep() { return "Animal::Sleep"; }
        public Animal()
        {
            Console.WriteLine("animal constructor");

        }
    }

    class Fish : Animal
    {
        public string Breathe() { return "fish::Breathe"; }
        public override string Eat() { return "fish::Eat"; }
        public new string Sleep() { return "fish::Sleep"; }
        public string Swim() { return "fish::Swim"; }
        public Fish()
        {
            Console.WriteLine("fish constructor");

        }
    }
}
