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
            Console.WriteLine(fish.Breathe());  //Animal::Breathe
            Console.WriteLine(fish.Eat());      //fish::Eat
            Console.WriteLine(fish.Sleep());    //Animal::Sleep
            //Console.WriteLine(fish.Swim());
            Fish fish2 = new Fish();
            Console.WriteLine(fish2.Breathe());
            Console.WriteLine(fish2.Eat());
            Console.WriteLine(fish2.Sleep());
            Console.WriteLine(fish2.Swim());
            //Fish fish3 = (Fish)new Animal();

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

    class Bird : Animal
    {
        public sealed override string Breathe()
        {
            return base.Breathe();
        }

        public sealed override string Sleep()
        {
            return base.Sleep();
        }
    }

    class Penguin : Bird
    {
        public new string Breathe()
        {
            return "Penguin::Breathe";
        }

        // Can't override sealed method
        //public override string Sleep()
        //{
        //    return base.Eat();
        //}
    }
}
