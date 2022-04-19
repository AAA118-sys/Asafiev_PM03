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

    public int CompareTo(object o)
    {
        Cheese c = o as Cheese;
        if (c != null)
        {
            int result = manufacturer.CompareTo(c.manufacturer);
            if (result != 0)
            {
                return result;
            }
            return fatPercentage.CompareTo(c.fatPercentage);
        }
        else
        {
            throw new Exception("Невозможно сравнить два объекта");
        }
    }

}



    public void Sort()
    {
        Array.Sort(this.Products);
    }

    public void PrintToFile()
    {
        using (StreamWriter file = new StreamWriter("result.txt", false, Encoding.UTF8))
        {
            foreach (Cheese c in this.Products)
            {
                file.WriteLine(c.ToString());
            }
        }
    }
}

