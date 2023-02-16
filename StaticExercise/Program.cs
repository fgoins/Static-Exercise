namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var fahrenheit = TempConverter.CelsiusToFahrenheit(33.3);
            Console.WriteLine($"{fahrenheit}");

            var celsius = TempConverter.FahrenheitToCelsius(33.3);
            Console.WriteLine($"{celsius}");
        }
    }
}
