using System;
public static class TemperatureConverter
{
    //Constantes
    private const double ZeroCelsius = -273.15;
    private const double ZeroFahrenheit = -459.67;
    private const double ZeroKelvin = 0;

    //Métodos
    public static double CelsiusToFahrenheit(double celsius)
    {
        if (celsius < ZeroCelsius)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return (celsius * 9 / 5) + 32;
    }

    public static double CelsiusToKelvin(double celsius)
    {
        if (celsius < ZeroCelsius)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return celsius + 273.15;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        if (fahrenheit < ZeroFahrenheit)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return (fahrenheit - 32) / 1.8;
    }

    public static double FahrenheitToKelvin(double fahrenheit)
    {
        if (fahrenheit < ZeroFahrenheit)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return (fahrenheit + 459.67) * 5 / 9;
    }

    public static double KelvinToCelsius(double kelvin)
    {
        if (kelvin < ZeroKelvin)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return kelvin - 273.15;
    }

    public static double KelvinToFahrenheit(double kelvin)
    {
        if (kelvin < ZeroKelvin)
            throw new ArgumentOutOfRangeException("Abaixo do zero absoluto 🥶");

        return (kelvin * 1.8) - 459.67;
    }
}