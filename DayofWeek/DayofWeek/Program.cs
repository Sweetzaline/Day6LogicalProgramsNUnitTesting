using System;
namespace DayofWeek
{
    class Sample
    {
     public static void Main()
     {
        
        DateTime dt = new DateTime(2022, 7, 31);
        Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}",
                           dt, dt.DayOfWeek == DayOfWeek.Thursday);
        Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
     }
    }
}