using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public MyVector(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        public static MyVector operator *(MyVector v1, int value)
        {
            return new MyVector(v1.X * value, v1.Y * value, v1.Z * value);
        }

        public static MyVector operator *(int value, MyVector v1)
        {
            return new MyVector(v1.X * value, v1.Y * value, v1.Z * value);
        }

        public static MyVector operator +(MyVector v1, MyVector v2)
        {
            return new MyVector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static MyVector operator -(MyVector v1, MyVector v2)
        {
            return new MyVector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    }
}
