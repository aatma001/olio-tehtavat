using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T35_Laskutoimituksia
{
    public class ArrayCalcs
    {
        public static double CalculateSum(double[] numbers)
        {
            double value = 0.0;
            for(int i = 0; i < numbers.Length; i++)
            {
                value += numbers[i];
            }
            return Math.Round(value, 2);
        }

        public static double CalculateAverage(double[] numbers)
        {
            double value = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                value += numbers[i];
            }
            return Math.Round(value / numbers.Length, 2);
        }

        public static double ShowMin(double[] numbers)
        {
            return numbers.Min();
        }

        public static double ShowMax(double[] numbers)
        {
            return numbers.Max();
        }
    }
}

