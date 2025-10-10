using System;
class Program
{
    static void Main(string[] args)
    {
        // Operações

        // CelsiusToFahrenheit
        Console.Write("Temperatura em Celsius para ser convertida em Fahrenheit: ");
        try
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);

            Console.WriteLine($"\nAntes: {celsius}°C\nDepois: {fahrenheit}°F\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }

        // CelsiusToKelvin
        Console.Write("Temperatura em Celsius para ser convertida em Kelvin: ");
        try
        {
            double celsius = double.Parse(Console.ReadLine());

            double kelvin = TemperatureConverter.CelsiusToKelvin(celsius);

            Console.WriteLine($"\nAntes: {celsius}°C\nDepois: {kelvin}K\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }

        // FahrenheitToCelsius
        Console.Write("Temperatura em Fahrenheit para ser convertida em Celsius: ");
        try
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"\nAntes: {fahrenheit}°F\nDepois: {celsius}°C\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }

        // FahrenheitToKelvin
        Console.Write("Temperatura em Fahrenheit para ser convertida em Kelvin: ");
        try
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double kelvin = TemperatureConverter.FahrenheitToKelvin(fahrenheit);

            Console.WriteLine($"\nAntes: {fahrenheit}°F\nDepois: {kelvin}K\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }

        // KelvinToCelsius
        Console.Write("Temperatura em Kelvin para ser convertida em Celsius: ");
        try
        {
            double kelvin = double.Parse(Console.ReadLine());

            double celsius = TemperatureConverter.KelvinToCelsius(kelvin);

            Console.WriteLine($"\nAntes: {kelvin}K\nDepois: {celsius}°C\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }

        // KelvinToFahrenheit
        Console.Write("Temperatura em Kelvin para ser convertida em Fahrenheit: ");
        try
        {
            double kelvin = double.Parse(Console.ReadLine());

            double fahrenheit = TemperatureConverter.KelvinToFahrenheit(kelvin);

            Console.WriteLine($"\nAntes: {kelvin}K\nDepois: {fahrenheit}°F\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Só são aceitos números!");
            Console.WriteLine(e.Message);
        }
    }
}