using System;
using static System.Console;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(new Number()[50]);
            WriteLine(new Number()[Number.Parts.half]);
        }
    }

    class Number
    {
        int number = 90;
        public decimal this[int percent]
        {
            get => (decimal)number * percent / 100;
        }
        public decimal this[Parts part] => (decimal)number * (int)part / 100;
        public enum Parts
        {
            quarter = 25,
            half = 50,
            zeroSeven = 70
        }
    }    
}
