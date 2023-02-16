using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    //Now create a static class called TempConverter.
    //The class should have at least 2 methods, one called FahrenheitToCelsius
    //that will require a double as a parameter and return a double,
    //the other CelsiusToFahrenheit
    //which will also require a double as a parameter and return a double.
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double C)
        {
            double celsius = (C - 32) / 1.8;
            return celsius;
        }
        public static double CelsiusToFahrenheit(double f) 
        {
            double fahrenheit = (f * 1.8) +32;
            return fahrenheit;
        }

    }
}
