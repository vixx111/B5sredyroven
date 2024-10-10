using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение e: ");
        double e = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение t: ");
        double t = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double d = 7.8 * (Math.Pow(a, 2)) + 3.52 * Math.Sqrt(t) / Math.Log(Math.Sqrt(a) + 2 * Math.Sqrt(y) + Math.Pow(e, y));
        Console.WriteLine($"Значение D равно {d}.");
    }
}
