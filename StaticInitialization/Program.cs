using System;

namespace StaticInitialization
{
    partial class  Program
    {
        static int x = y;
        static int y = 3;
        static void Main(string[] args)
        {
            OnSomethingHappened("dupa");
            Console.WriteLine($"x = {x}, y = {y}"); //x = 0, y = 3            
        }
        static partial  void OnSomethingHappened(string s);
    }
}
