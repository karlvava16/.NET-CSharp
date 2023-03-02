using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{

    internal class Program
    {
        static void SaveToFile(List<int> numbers, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
        static void Task1()
        {
            Random rand = new Random();
            int[] numbers = new int[100];
            List<int> primeNumbers = new List<int>();
            List<int> fibonacciNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 400);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0 && i != 0)
                    Console.WriteLine();
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }

                if (IsFibonacci(number))
                {
                    fibonacciNumbers.Add(number);
                }
            }

            SaveToFile(primeNumbers, "PrimeNumbers.txt");
            SaveToFile(fibonacciNumbers, "FibonacciNumbers.txt");

        }

        static void ReplaceWords(string fileName, string searchWord, string replaceWord)
        {
            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(searchWord, replaceWord);

            }

            File.WriteAllLines(fileName, lines);
        }


        static void Task2()
        {
            Console.WriteLine("Введите имя файла:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Введите слово для поиска:");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Введите слово для замены:");
            string replaceWord = Console.ReadLine();

            ReplaceWords(fileName, searchWord, replaceWord);
        }

        static void Task3()
        {
            Console.WriteLine("Введите путь к файлу с текстом:");
            string textFilePath = Console.ReadLine();

            Console.WriteLine("Введите путь к файлу со словами для модерирования:");
            string filterFilePath = Console.ReadLine();

            string[] filterWords = File.ReadAllLines(filterFilePath);

            string text = File.ReadAllText(textFilePath);

            foreach (string filterWord in filterWords)
            {
                text = text.Replace(filterWord, new string('*', filterWord.Length));
            }

            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();

            Task3();
        }
    }
    
}
