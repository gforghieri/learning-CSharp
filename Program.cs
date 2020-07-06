using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args) => WorkingWithIntegers();


        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;


            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }
    }
}