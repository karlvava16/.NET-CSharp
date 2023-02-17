using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    abstract class Task3
    {
        public static bool Even(int value)
        {
            if(value % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool Odd(int value)
        {
            if (value % 2 != 0)
                return true;
            else
                return false;
        }

        public static bool Prime(int value)
        {
            if (value <= 1)
            {
                return false;
            }

            for (int i = 2; i < value; i++)
            {
                if(value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Fib(int value)
        {
            if(value < 0)
                throw new ArgumentOutOfRangeException();
            if(value == 0)
                return true;

            for (int i = 0, j = 1; i <= value;)
            {
                (j, i) = (i, j);
                j += i;
                if (j == value)
                    return true;
            }
            return false;
        }
    }
}
