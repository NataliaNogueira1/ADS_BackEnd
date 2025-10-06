using System;
public static class UnitConverter
{
    //Constantes
    private const double MmToM = 1000;
    private const double GToKg = 1000;
    private const double HToS = 3600;
    private const double MToS = 60;

    //Métodos
    public static double Converter(double mm)
    {
        return mm / MmToM;
    }

    public static double Converter(int g)
    {
        return g / GToKg;
    }

    public static int Converter(double h, double min)
    {
        if (min > 60)
            min = min % 60;
        double r = (h * HToS) + (min * MToS);
        return (int)r;
    }
}