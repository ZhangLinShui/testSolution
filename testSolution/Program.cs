using System;

namespace testSolution
{
    class Program
    {
        static Class2 class2 = new Class2();
        static Class1 class1 = new Class1();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!"); Console.WriteLine("Hello World!"); Console.WriteLine("Hello World!");

            Console.WriteLine("你好  世界");

            class2.PrintMy2();
            class1.PrintMy();

            Console.WriteLine("Solution 改变");
            Console.WriteLine("netcoreapp3.3");
        }
    }
}
