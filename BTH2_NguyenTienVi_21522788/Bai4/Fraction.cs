using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction a)
        {
            this.numerator = a.numerator;
            this.denominator = a.denominator;
        }
        static int GCD(int a, int b)
        {
            while (b > 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        static public Fraction Simplify(Fraction a)
        {
            return new Fraction(a.numerator / GCD(a.numerator, a.denominator), a.denominator / GCD(a.numerator, a.denominator));
        }
        public void Input()
        {
            Console.Write("Numerator: ");
            numerator = int.Parse(Console.ReadLine());
            Console.Write("Denominator: ");
            denominator = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            if (numerator == 0)
            {
                Console.Write(0);
            }
            else if (numerator == denominator)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(numerator + "/" + denominator);
            }
        }

        public double GetValue()
        {
            return 1.0 * numerator / denominator;
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.numerator, a.denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * new Fraction(b.denominator, b.numerator);
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.GetValue() > b.GetValue();
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.GetValue() < b.GetValue();
        }
    }

}
