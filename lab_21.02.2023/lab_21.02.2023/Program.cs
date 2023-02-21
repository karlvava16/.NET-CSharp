using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        delegate bool Task_1(int value);
        static void Task1()
        {

            bool result;
            bool Do(int value, Task_1 od)
            {
                return od(value);
            }

            result = Do(13, delegate(int value)
                {
                    if(value%2 == 0)
                        return true;
                    else
                        return false;
            });
            Console.WriteLine(result);

        }

        delegate int Task_2(int value);

        static void Task2()
        {
            int result;
            int Do(int value, Task_2 od)
            {
                return od(value);
            }

            result = Do(4, delegate (int value)
            {
                return value * value;
            });
            Console.WriteLine(result);
        }

        delegate int Task_3(int value);

        static void Task3()
        {
            int result;
            int Do(int value, Task_2 od)
            {
                return od(value);
            }

            result = Do(4, x=> x*x*x);
            Console.WriteLine(result);
        }


        delegate bool Task_4(int value);


        static void Task4()
        {
            bool result;
            bool Do(DateTime value, Task_4 od)
            {
                if (od(value.DayOfYear))
                    return true;
                else
                    return false;
            }

            result = Do(new DateTime(2023,09,13), x => (x == 256));
            Console.WriteLine(result);
        }


        delegate bool Task_5_6(int value, int value2);

        static int Do(int[] arr, Task_5_6 od)
        {
            int re = arr[0];
            foreach (var item in arr)
            {
                if (od(item, re))
                    re = item;
            }
            return re;
        }

        static void Task5()
        {
            int[] array = new int[10] { 0, 2, 5, 6, 10, 1, 4, 5, 6, 2 };
            int result;
            
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            result = Do(array, (x,y) => x > y);
            Console.WriteLine(result);
        }

        static void Task6()
        {
            int[] array = new int[10] { 0, 2, 5, 6, 10, 1, 4, 5, 6, 2 };
            int result;

            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            result = Do(array, (x, y) => x < y);
            Console.WriteLine(result);
        }

        delegate bool Task_7(int value);


        static int Do(int[] arr, Task_7 od)
        {
            int re = 0;
            foreach (var item in arr)
            {
                if (od(item))
                    re++;
            }
            return re;
        }

        static void Task7()
        {
            int[] array = new int[10] { 0, 2, 5, 6, 10, 1, 4, 5, 6, 2 };
            int result;

            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            result = Do(array, x => x % 2 == 0);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }
    }
}
