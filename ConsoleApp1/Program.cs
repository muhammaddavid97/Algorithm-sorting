using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive.printNumbers(5);
            //Recursive.printOddNumbers(5);

            /*int n = 5;
            Console.WriteLine("Fibonacci series of 5 numbers is : ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Recursive.fibonacci(i));
            }*/

            Console.WriteLine($"factorial dari {5} adalah {Recursive.factorial(5)}");
        }
    }
}
