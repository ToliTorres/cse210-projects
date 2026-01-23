using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Fraction f4 = new Fraction(3, 4);
        Fraction f5 = new Fraction(1, 3);

        // Display fraction and decimal values
        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);
        DisplayFraction(f4);
        DisplayFraction(f5);

        // Test setters and getters
        f1.SetTop(5);
        f1.SetBottom(8);

        Console.WriteLine("\nAfter using setters on f1:");
        Console.WriteLine($"Top: {f1.GetTop()}");
        Console.WriteLine($"Bottom: {f1.GetBottom()}");
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");
    }

    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine($"Fraction: {f.GetFractionString()}");
        Console.WriteLine($"Decimal: {f.GetDecimalValue()}");
        Console.WriteLine();
    }
}