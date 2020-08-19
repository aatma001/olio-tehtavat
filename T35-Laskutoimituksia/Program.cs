using System;

namespace T35_Laskutoimituksia
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double[] numbers = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine("Sum: " + ArrayCalcs.CalculateSum(numbers));
            Console.WriteLine("Average: " +ArrayCalcs.CalculateAverage(numbers));
            Console.WriteLine("Min: " + ArrayCalcs.ShowMin(numbers));
            Console.WriteLine("Max: " + ArrayCalcs.ShowMax(numbers));
 
        }
    }
}
