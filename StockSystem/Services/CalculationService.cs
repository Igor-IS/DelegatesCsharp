

using System;
using System.Globalization;

namespace StockSystem.Services
{
    class CalculationService
    {
        // methods for test the concat in delegates
        public static double Max(double number, double number2)
        {
            return (number > number2) ? number : number2; 
        }

        public static double Sum(double number, double number2)
        {
            return number + number2;
        }

        public static double Square(double number, double number2)
        {
            return number * number2;
        }

        public static void ShowMax(double number, double number2)
        {
            double max = (number > number2) ? number : number2;
            Console.WriteLine($"Max: {max.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ShowSum(double number, double number2)
        {
            double sum = number + number2;
            Console.WriteLine($"Sum: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
