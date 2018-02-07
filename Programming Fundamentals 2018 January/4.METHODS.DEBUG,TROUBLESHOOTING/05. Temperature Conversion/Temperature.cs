using System;
//Create a method that converts a temperature from Fahrenheit to Celsius. Format the result to the 2 nd decimal point.
//Use the formula: (fahrenheit - 32) * 5 / 9.

namespace _05.Temperature_Conversion
{
    class Temperature
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheittoCelsius(fahrenheit);
            Console.WriteLine("{0:F2}",celsius);

        }

        private static double FahrenheittoCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
