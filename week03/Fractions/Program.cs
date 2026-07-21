using System;

class Program
{
    static void Main(string[] args)
    {
        // No parameter constructor
        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.Decimal());

        // One parameter constructor
        Fraction fraction2 = new Fraction(5);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.Decimal());

        // One parameter constructor
        Fraction fraction3 = new Fraction(3, 4);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.Decimal());

        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.Decimal());


    }
}