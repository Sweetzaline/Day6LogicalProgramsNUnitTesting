using System;


namespace UC2_PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;

            Console.Write("\n\n");
            Console.Write("Check whether a number is perfect number:\n");
            Console.Write("\n\n");

            Console.Write("Enter the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            {
                Console.Write("The positive divisor  : ");
            }

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\n, the number is perfect.");
            else
                Console.Write("\n, the number is not perfect.");
            Console.Write("\n");
        }
    }
}