using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction myFraction1 = new Fraction();

        Console.WriteLine("First Test");

        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());


        Console.WriteLine("Second Test");
        Fraction myFraction2 = new Fraction(6);

        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());


        Console.WriteLine("Third Test");
        Fraction myFraction3 = new Fraction(6, 7);


        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());

        Console.WriteLine("Fourth Test");
        Fraction myFraction4 = new Fraction(1, 3);
        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetDecimalValue());

    }
}