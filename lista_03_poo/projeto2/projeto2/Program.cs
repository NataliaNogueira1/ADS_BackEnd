using System;
class Program
{
    static void Main(string[] args)
    {
        // Operações

        // milimetros ↔ metros
        Console.WriteLine("Milimetros para metros:");
        try
        {
            Console.WriteLine(UnitConverter.Converter(838.0));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // gramas ↔ kilogramas
        Console.WriteLine("Gramas para kilogramas:");
        try
        {
            Console.WriteLine(UnitConverter.Converter(2560));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // horas:minutos ↔ segundos
        Console.WriteLine("Horas e minutos para segundos:");
        try
        {
            Console.WriteLine(UnitConverter.Converter(7.0, 39.0));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // horas:minutos ↔ segundos
        Console.WriteLine("Horas e minutos para segundos:");
        try
        {
            Console.WriteLine(UnitConverter.Converter(7.38, 100.0));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}