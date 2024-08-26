namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is today's temperature in Fahrenheit?");
            var userInput = double.Parse(Console.ReadLine());
            var celsius = TempConverter.FahrenheitToCelsius(userInput);
            Console.WriteLine($"{userInput} degrees Fahrenheit converts to {celsius} degrees Celsius.");
            
            Console.WriteLine("");
            
            Console.WriteLine("What is today's temperature in Celsius?");
            var secondInput = double.Parse(Console.ReadLine());
            var fahrenheit = TempConverter.CelsiusToFahrenheit(secondInput);
            Console.WriteLine($"{secondInput} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
        }
    }
}
