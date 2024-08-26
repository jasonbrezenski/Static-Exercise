namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double temp1)
    {
        return (temp1 - 32) / 1.8;
    }

    public static double CelsiusToFahrenheit(double temp2)
    {
        return 1.8 * temp2 + 32;
    }
}