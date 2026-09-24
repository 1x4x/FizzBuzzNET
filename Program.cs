using System;

namespace FizzBuzzNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int n = int.Parse(input[2]);
            FizzBuzz(x, y, n);
        }

        public static void FizzBuzz(int x, int y, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
