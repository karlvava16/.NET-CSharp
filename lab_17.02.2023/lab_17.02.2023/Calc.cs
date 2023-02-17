using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    abstract class Calc
    {
        public static double Sum(double first, double second)
        {
            return first + second;
        }
        public static double Mult(double first, double second)
        {
            return first * second;
        }
        public static double Dev(double first, double second)
        {
            if(second == 0)
                throw new DivideByZeroException();
            return first + second;
        }
        public static double Sub(double first, double second)
        {
            return first - second;
        }
    }
}
