using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Figure
    {
        public abstract double S();
    }


    class Circle : Figure
    {
        public double R { get; set; }

        public override double S()
        {
            return Math.PI * R * R;
        }

        public Circle(double r)
        {
            R = r;
        }

        public override string ToString()
        {
            return $"|Circle|S\n: {S()}\n";
        }
    }

    class Rectangle : Figure
    {
        public double W { get; set; }
        public double H { get; set; }


        public override double S()
        {
            return W * H;
        }

        public Rectangle(double w, double h)
        {
            W = w;
            H = h;
        }

        public override string ToString()
        {
            return $"|Rectangle|S\n: {S()}\n";
        }


    }

    class RightTriangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }


        public override double S()
        {
            return A * B / 2;
        }

        public RightTriangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
        {
            return $"|Right Triangle|S\n: {S()}\n";
        }


    }

    class Trapezoid : Figure
    {
        public double M { get; set; }
        public double H { get; set; }


        public override double S()
        {
            return M * H;
        }

        public Trapezoid(double m, double h)
        {
            M = m;
            H = h;
        }

        public override string ToString()
        {
            return $"|Trapezoid|S\n: {S()}\n";
        }


    }

}
