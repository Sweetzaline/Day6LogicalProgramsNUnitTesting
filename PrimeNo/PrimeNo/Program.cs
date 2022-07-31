using System;
namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Program.prime(y);
        }
        public static void prime(int num)
        {
            for (int i = 2; i <= (num/2); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i} is not a prime no {num}");
                }
                else
                {
                    Console.WriteLine($"{num} is a prime no ");
                }
            }

        }
    }
}