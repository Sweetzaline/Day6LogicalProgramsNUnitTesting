using System;
namespace CouponNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var stringChars = new char[15];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                Console.WriteLine(" Your Coupon Number is: " + stringChars[i]);

            }
        }
    }
}