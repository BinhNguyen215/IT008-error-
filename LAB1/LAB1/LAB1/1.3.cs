using System;

class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    // Hàm tìm ước chung lớn nhất (GCD) để rút gọn phân số
    private int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Hàm rút gọn phân số
    public void Simplify()
    {
        int gcd = FindGCD(Numerator, Denominator);
        Numerator /= gcd;
        Denominator /= gcd;
    }

    // Hàm cộng hai phân số
    public static Fraction operator +(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.Denominator * fraction2.Denominator;
        int numerator = (fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator);
        return new Fraction(numerator, commonDenominator);
    }

    // Hàm trừ hai phân số
    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.Denominator * fraction2.Denominator;
        int numerator = (fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator);
        return new Fraction(numerator, commonDenominator);
    }

    // Hàm nhân hai phân số
    public static Fraction operator *(Fraction fraction1, Fraction fraction2)
    {
        int numerator = fraction1.Numerator * fraction2.Numerator;
        int denominator = fraction1.Denominator * fraction2.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Hàm chia hai phân số
    public static Fraction operator /(Fraction fraction1, Fraction fraction2)
    {
        int numerator = fraction1.Numerator * fraction2.Denominator;
        int denominator = fraction1.Denominator * fraction2.Numerator;
        return new Fraction(numerator, denominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(1, 6);

        Fraction sum = fraction1 + fraction2;
        Fraction difference = fraction1 - fraction2;
        Fraction product = fraction1 * fraction2;
        Fraction quotient = fraction1 / fraction2;

        sum.Simplify();
        difference.Simplify();
        product.Simplify();
        quotient.Simplify();

        Console.WriteLine($"Tổng: {sum}");
        Console.WriteLine($"Hiệu: {difference}");
        Console.WriteLine($"Tích: {product}");
        Console.WriteLine($"Thương: {quotient}");
    }
}
