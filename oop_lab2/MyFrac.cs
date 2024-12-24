
using System.Text;

namespace oop_lab2
{
    public class MyFrac
    {
        private long nom;
        private long denom;
        public MyFrac(long nom_, long denom_)
        {
            if (denom_ == 0)
            {
                throw new ArgumentException("Denominator can't be zero.");

            }

            if (denom_ < 0)
            {
                nom_ = -nom_;
                denom_ = -denom_;
            }

            long gcd = GCD(Math.Abs(nom_), denom_);
            nom = nom_ / gcd;
            denom = denom_ / gcd;
        }

        public long Nominator => nom;
        public long Denominator => denom;
        public override string ToString()
        {
            return $"{nom}/{denom}";
        }

        public string ToStringWithIntPart()
        {
            string sign;
            if (Nominator * Denominator < 0)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            long integerPart = Math.Abs(Nominator) / Denominator;
            long fractionalPart = Math.Abs(Nominator) % Denominator;

            if (integerPart == 0)
            {
                return $"{sign}{fractionalPart}/{Denominator}";

            }
            else if (fractionalPart == 0)
            {
                return $"{sign}{integerPart}";

            }
            else
            {
                return $"{sign}{integerPart} + {fractionalPart}/{Denominator}";
            }
        }

        public double ToDouble()
        {
            return (double)nom / denom;
        }

        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static MyFrac operator +(MyFrac f1, MyFrac f2)
        {
            long nom = f1.Nominator * f2.Denominator + f2.Nominator * f1.Denominator;
            long denom = f1.Denominator * f2.Denominator;
            return new MyFrac(nom, denom);
        }

        public static MyFrac operator -(MyFrac f1, MyFrac f2)
        {
            long nom = f1.Nominator * f2.Denominator - f2.Nominator * f1.Denominator;
            long denom = f1.Denominator * f2.Denominator;
            return new MyFrac(nom, denom);
        }

        public static MyFrac operator *(MyFrac f1, MyFrac f2)
        {
            long nom = f1.Nominator * f2.Nominator;
            long denom = f1.Denominator * f2.Denominator;
            return new MyFrac(nom, denom);
        }

        public static MyFrac operator /(MyFrac f1, MyFrac f2)
        {
            long nom = f1.Nominator * f2.Denominator;
            long denom = f1.Denominator * f2.Nominator;
            return new MyFrac(nom, denom);
        }

    }
}
