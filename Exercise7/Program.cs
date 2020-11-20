using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempFarenheit = 0;
            int calcCelcius = intToCelcius(tempFarenheit);
            int calcFarenheit = intToFarenheit(calcCelcius);
            Console.WriteLine($"Original int farenheit val: {tempFarenheit}");
            Console.WriteLine($"Calculated int celcius val: {calcCelcius}");
            Console.WriteLine($"Calculated int farenheit val: {calcFarenheit}");

            float floatTempFarenheit = 0;
            float floatCalcCelcius = floatToCelcius(floatTempFarenheit);
            float floatCalcFarenheit = floatToFarenheit(floatCalcCelcius);
            Console.WriteLine($"Original float farenheit val: {floatTempFarenheit}");
            Console.WriteLine($"Calculated float celcius val: {floatCalcCelcius}");
            Console.WriteLine($"Calculated float farenheit val: {floatCalcFarenheit}");

            double doubleTempFarenheit = 0;
            double doubleCalcCelcius = doubleToCelcius(doubleTempFarenheit);
            double doubleCalcFarenheit = doubleToFarenheit(doubleCalcCelcius);
            Console.WriteLine($"Original float farenheit val: {doubleTempFarenheit}");
            Console.WriteLine($"Calculated float celcius val: {doubleCalcCelcius}");
            Console.WriteLine($"Calculated float farenheit val: {doubleCalcFarenheit}");

        }

        public static int intToCelcius(int temp)
        {
            return ((temp - 32) / 9) * 5;
        }
        public static int intToFarenheit(int temp)
        {
            return ((temp * 9) / 5) + 32;
        }

        public static float floatToCelcius(float temp)
        {
            return ((temp - 32) / 9) * 5;
        }
        public static float floatToFarenheit(float temp)
        {
            return ((temp * 9) / 5) + 32;
        }
        public static double doubleToCelcius(double temp)
        {
            return ((temp - 32) / 9) * 5;
        }
        public static double doubleToFarenheit(double temp)
        {
            return ((temp * 9) / 5) + 32;
        }
    }
}
