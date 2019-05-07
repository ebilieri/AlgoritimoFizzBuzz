using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                decimal r3 = i % 3;
                decimal r5 = i % 5;

                if (r3 == 0 && r5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (r3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (r5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
