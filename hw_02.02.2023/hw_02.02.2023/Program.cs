using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_02._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        static void FirstTask()
        {
            int[][] ptr;
            int min, max;
            Random rand = new Random();

            ptr = new int[rand.Next(3, 5)][];

            for (int i = 0; i < ptr.Length; i++)
            {
                ptr[i] = new int[rand.Next(2, 20)];
            }

            min = max = 0;

            for (int i = 0; i < ptr.Length; i++)
            {
                for (int j = 0; j < ptr[i].Length; j++)
                {
                    Console.Write(ptr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < ptr.Length; i++)
            {
                if (ptr[max].Length < ptr[i].Length)
                {
                    max = i;
                }
                if (ptr[min].Length > ptr[i].Length)
                {
                    min = i;
                }
            }

            (ptr[min], ptr[max]) = (ptr[max], ptr[min]);

            for (int i = 0; i < ptr.Length; i++)
            {
                for (int j = 0; j < ptr[i].Length; j++)
                {
                    Console.Write(ptr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void SecondTask()
        {
            int[][] ptr;
            int min, max;
            Random rand = new Random();

            ptr = new int[rand.Next(5, 10)][];

            for (int i = 0; i < ptr.Length; i++)
            {
                ptr[i] = new int[ptr.Length - i];
            }

            for (int i = 0; i < ptr.Length; i++)
            {
                for (int j = 0; j < ptr[i].Length; j++)
                {
                    Console.Write(ptr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
