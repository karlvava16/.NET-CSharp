using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector() { }

        public Vector(double x)
        {
            X = x;
        }

        public Vector(double x, double y) : this(x)
        {
            Y = y;
        }

        public Vector(double x, double y, double z) : this(x, y)
        {
            Z = z;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public void Input()
        {
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            Z = Convert.ToDouble(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("X: {0}\tY: {1}\tZ: {2}", X, Y, Z);
        }

        public Vector Sum(double scal)
        {
            Vector v = new Vector(X + scal, Y + scal, Z + scal);
            return v;
        }
        public Vector Sum(Vector v2)
        {
            Vector v = new Vector(X + v2.X, Y + v2.Y, Z + v2.Z);
            return v;
        }

        public Vector Sub(double scal)
        {
            Vector v = new Vector(X - scal, Y - scal, Z - scal);
            return v;
        }

        public Vector Sub(Vector v2)
        {
            Vector v = new Vector(X - v2.X, Y - v2.Y, Z - v2.Z);
            return v;
        }

        public Vector Mult(Vector v2)
        {
            Vector v = new Vector(X * v2.X, Y * v2.Y, Z * v2.Z);
            return v;
        }

        public double ScalMult(Vector v2)
        {
            return (X * v2.X + Y * v2.Y + Z * v2.Z);
        }

        public override string ToString()
        {
            return $"X: {X}\tY: {Y}\tZ: {Z}";
        }

        public bool Equal(Vector v)
        {
            return GetLength() == v.GetLength();
        }

        public double Angle(Vector v2)
        {
            return Math.Cos(ScalMult(v2) / (GetLength() * v2.GetLength()));
        }

    }
}
