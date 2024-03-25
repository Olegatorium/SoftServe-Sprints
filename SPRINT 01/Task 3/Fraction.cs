using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_01.Task_3
{
    class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        private int num; 
        private int den;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            this.num = numerator;
            this.den = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(num), Math.Abs(den));
            num /= gcd;
            den /= gcd;
            if (den < 0)
            {
                num = -num;
                den = -den;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Fraction operator +(Fraction fraction)
        {
            return fraction;
        }

        public static Fraction operator -(Fraction fraction)
        {
            return new Fraction(-fraction.num, fraction.den);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.num * b.den + b.num * a.den;
            int denominator = a.den * b.den;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.num * b.den - b.num * a.den;
            int denominator = a.den * b.den;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.num * b.num;
            int denominator = a.den * b.den;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            int numerator = a.num * b.den;
            int denominator = a.den * b.num;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator !(Fraction fraction)
        {
            return new Fraction(fraction.den, fraction.num);
        }

        public override string ToString()
        {
            return $"{num} / {den}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fraction))
                return false;

            Fraction other = (Fraction)obj;
            return this.num == other.num && this.den == other.den;
        }

        public override int GetHashCode()
        {
            return num.GetHashCode() ^ den.GetHashCode();
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
    }
}
