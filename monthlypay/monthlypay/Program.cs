using System;
namespace monthlypay
{
    class monthlyPayment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal Loan amount: ");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Years: ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the percent interest compounded: ");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * y;
            double r = R / (12 * 100);
            double payment = p * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(payment + "is monthly payment");
        }
       

    }
}