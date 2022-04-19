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

public class MilkFarm
{
    int cntProducts;
    public Cheese[] Products;

    public MilkFarm(int cntProducts)
    {
        this.cntProducts = cntProducts;
        Products = new Cheese[cntProducts];
    }

    public void Fill()
    {
        string brand;
        string manufacturer;
        int fatPercentage;
        for (int i = 0; i < this.cntProducts; i++)
        {
            Console.WriteLine("Марка:");
            brand = Console.ReadLine();
            Console.WriteLine("Производитель:");
            manufacturer = Console.ReadLine();
            Console.WriteLine("Процент жирности:");
            fatPercentage = Convert.ToInt32(Console.ReadLine());
            this.Products[i] = new Cheese(brand, manufacturer, fatPercentage);
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

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Количество продуктов:");
        int cntProducts = Convert.ToInt32(Console.ReadLine());
        MilkFarm milkFarm = new MilkFarm(cntProducts);
        milkFarm.Fill();
        milkFarm.Sort();
        milkFarm.PrintToFile();
    }
}

