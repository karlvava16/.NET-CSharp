using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    struct ComplexNumber
    {
        public int A { get; set; }
        public int B { get; set; }

        public bool I { get; }

        public ComplexNumber(int a, int b, bool i = true)
        {
            I = i;
            A = a;
            B = b;
        }

        public static ComplexNumber operator + (ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.A + obj2.A, obj1.B * -1 + obj1.B * -1, false);

        }

        public static ComplexNumber operator *(ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.A + obj2.A, obj1.B * -1 + obj1.B * -1, false);

        }
         public static ComplexNumber operator - (ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.A + obj2.A, obj1.B * -1 + obj1.B * -1, false);

        }

        public static ComplexNumber operator /(ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.A + obj2.A, obj1.B * -1 + obj1.B * -1, false);

        }
        public override string ToString() {
            if(I)
                return A.ToString() + "" + B.ToString() + "*i";
            return Convert.ToString(A + B * -1);
        }
    }
}
