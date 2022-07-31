using System;
namespace tempConv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temp is Celcius: ");
            double celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Temp is fahrenheit: ");
            double fahrenheit = Convert.ToInt32(Console.ReadLine());

            double celToFah = (celsius * 9 / 5) + 32;
            double fahToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("After celsius to fahrenheit conversion: {0}", celToFah);
            Console.WriteLine("After fahrenheit to celsius conversion: {0}", fahToCel);
        }
    }

}