using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("What is your name?");
           //string name = Console.ReadLine();

           // Console.WriteLine($"Hi {name}.  What is your favorite color?");
           // string color = Console.ReadLine();

           //Console.WriteLine("What is your favorite animal?");
           // string animal = Console.ReadLine();

           //Console.WriteLine("What is your favorite band?");
           // string band = Console.ReadLine();

           //Console.WriteLine($"{name}'s pet is a {color} {animal}.  When {name}'s pet is lazing around the lake he likes to listen to {band}");
        
         Console.WriteLine("We are working on operands. Let's start with sum. Provide two number.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int adding = num1 + num2;// this is my call
         Console.WriteLine($"Sum is: {adding}");

         Console.WriteLine("How about we try multiplication.  What are two different numbers?");
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int multiply = num3 * num4;// this is my call
            Console.WriteLine($"Multiple would be: {multiply}");

         Console.WriteLine("Division is hard sometimes.  Lets start by using even numbers. Provide me with two even numbers?");
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());

            int division = num5 / num6;// this is my call
            Console.WriteLine($"Answer would be: {division}");

        }
    }
}
