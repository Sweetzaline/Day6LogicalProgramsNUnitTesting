using System;
namespace ReverseNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;

            Console.WriteLine("Enter an integer \n");

            num = int.Parse(Console.ReadLine());

            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
           
            Console.WriteLine("The reverse of the number is = {0}", reverse);
            Console.Read();
        }
    }
}