using System;
using System.Diagnostics.CodeAnalysis;

public class Fraction: IEquatable<Fraction>, IComparable<Fraction>
{
    private int licznik { get; }
    private int mianownik { get; }

    public Fraction()
    {

    }
    public Fraction(int licznik, int mianownik)
    {
        this.licznik = licznik;
        this.mianownik = mianownik;
    }
    Fraction(Fraction otherFraction)
    {
        this.licznik = otherFraction.licznik;
        this.mianownik = otherFraction.mianownik;
    }

    public int CompareTo([AllowNull] Fraction other)
    {
        throw new NotImplementedException();
    }

    public bool Equals([AllowNull] Fraction other)
    {
        return (decimal)this.licznik * other.mianownik == (decimal)other.licznik * this.mianownik;
    }

    public override string ToString() => $"{licznik} / {mianownik}";

    public static Fraction operator +(Fraction a) => a;
    public static Fraction operator -(Fraction a) => new Fraction(-a.licznik, a.mianownik);

    public static Fraction operator +(Fraction a, Fraction b)
    => new Fraction(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);

    public static Fraction operator -(Fraction a, Fraction b)
        => a + (-b);

    public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.licznik * b.licznik, a.mianownik * b.mianownik);

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.licznik == 0)
        {
            throw new DivideByZeroException();
        }
        return new Fraction(a.licznik * b.mianownik, a.mianownik * b.licznik);
    }


    public int Floor ()
    {
        return (int)Math.Floor((double)this.licznik/this.mianownik);
    }
    
    public int Ceiling()
    {
        return (int)Math.Ceiling((double)this.licznik/this.mianownik);
    }
}