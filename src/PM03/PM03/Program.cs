using System;
using System.IO;
using System.Text;

public class Cheese : IComparable
{
    public string brand;
    public string manufacturer;
    public int fatPercentage;

    public Cheese(string brand, string manufacturer, int fatPercentage)
    {
        this.brand = brand;
        this.manufacturer = manufacturer;
        this.fatPercentage = fatPercentage;
    }

    public string ToString()
    {
        return string.Format("Марка: {0}  Производитель: {1} Процент жирности: {2}", brand, manufacturer, fatPercentage);
    }

    