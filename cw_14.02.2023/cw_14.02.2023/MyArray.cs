﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Classwork
{
    class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        int[] array;

        public MyArray(params int[] array)
        {
            this.array = array;
        }

        public MyArray(int length)
        {
            this.array = new int[length];
        }

        public void Rand(int first, int second)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(first, second);
            }
        }

        public float Avg()
        {
            float a = 0.0f;
            foreach (var item in array)
            {
                a += item;
            }
            a /= array.Length;
            return a;
        }

        public int Max()
        {
            int max = array[0];
            foreach (var item in array)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var item in array)
            {
                if(valueToSearch == item)
                    return true;
            }
            return false;
        }

        public void Show()
        {
            foreach (int i in this.array) 
            { 
                Console.Write(i + " ");
            }
        }

        public void Show(string info)
        {
            Show();
            Console.Write("\n" + info);
        }

        

        public void SortAsc()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();

        }

        public int Less(int valueToCompare)
        {
            int temp = 0;
            foreach (var item in array)
            {
                if (item < valueToCompare)
                    temp++;
            }
            return temp;
        }

        public int Greater(int valueToCompare)
        {
            int temp = 0;
            foreach (var item in array)
            {
                if (item > valueToCompare)
                    temp++;
            }
            return temp;
        }

        public void ShowEven()
        {
            foreach (int i in array)
            {
                if(i % 2 == 0)
                Console.Write(i + " ");
            }
        }

        public void ShowOdd()
        {
            foreach (int i in array)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }

        public int CountDistinct()
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                temp++;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        temp--;
                        break;
                    }
                }
            }
            return temp;
        }

        public int EqualToValue(int valueToCompare)
        {
            int temp = 0;
            foreach (var item in array)
            {
                if (item == valueToCompare)
                {
                    temp++;
                }
            }
            return temp;
        }
    }
}
