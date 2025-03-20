using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            FizzBuzzHelper(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
        }

        static void FizzBuzzHelper(int x, int y, int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                if (i%x == 0 || i%y == 0)
                {
                    if (i%x == 0)
                    {
                        Console.Write("Fizz");
                    }
                    if (i%y == 0)
                    {
                        Console.Write("Buzz");
                    }
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }
    }
}