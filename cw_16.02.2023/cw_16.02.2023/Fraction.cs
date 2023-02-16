using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    struct Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        { get { return numerator; } set { numerator = value; } }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException();
                }
                denominator = value;
            }
        }

        public Fraction(int numerator, int denominator) : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            if (obj1.Denominator == obj2.Denominator)
            {
                return new Fraction(obj1.Numerator + obj2.Numerator, obj2.Denominator);
            }
            else
            {
                return new Fraction(obj1.Numerator * obj2.Denominator + obj2.Numerator * obj1.Denominator, obj2.Denominator * obj1.Denominator);
            }
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            if (obj1.Denominator == obj2.Denominator)
            {
                return new Fraction(obj1.Numerator - obj2.Numerator, obj2.Denominator);
            }
            else
            {
                return new Fraction(obj1.Numerator * obj2.Denominator - obj2.Numerator * obj1.Denominator, obj2.Denominator * obj1.Denominator);
            }
        }

        public static Fraction operator *(Fraction obj1, Fraction obj2)
        {
            return new Fraction(obj1.Numerator * obj2.Numerator, obj2.Denominator * obj1.Denominator);
        }

        public static Fraction operator /(Fraction obj1, Fraction obj2)
        {
            if (obj2.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(obj1.Numerator * obj2.Denominator, obj1.Denominator * obj2.Numerator);

        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}
