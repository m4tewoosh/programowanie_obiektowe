using System;

namespace Fraction1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);

            Fraction fraction2 = new Fraction(1, 2);

            Console.WriteLine(fraction1.Equals(fraction2));

            Console.WriteLine(fraction1.Floor());
            Console.WriteLine(fraction1.Ceiling());


        }
    }
}
