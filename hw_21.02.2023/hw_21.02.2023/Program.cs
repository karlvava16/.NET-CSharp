using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework
{
    class Program
    {
        delegate int[] Rainbow(int x);
        static void Main(string[] args)
        {



            Rainbow rgb = delegate (int x)
            {
                int[] RGB = { 0, 0, 0 };

                switch (x)
                {
                    case 1: RGB[0] = 255; break;
                    case 2: RGB[0] = 252; RGB[1] = 102; break;
                    case 3: RGB[0] = 255; RGB[1] = 255; break;
                    case 4: RGB[0] = 0; RGB[1] = 255; break;
                    case 5: RGB[1] = 0; RGB[1] = 128; RGB[2] = 255; break;
                    case 6: RGB[1] = 0; RGB[1] = 0; RGB[2] = 255; break;
                    case 7: RGB[1] = 128; RGB[1] = 0; RGB[2] = 255; break;


                    default:
                        break;
                }



                return RGB;
            };

            int[] rgbb = rgb(1);
            foreach (int item in rgbb)
            {
                Console.WriteLine(item);
            }

            //task2


            Backpack backpack = new Backpack("color", "firm", "textile", 1, 8);

            Items item1 = new Items("Item", 10);
            Console.WriteLine(backpack.V);
            backpack.AddItem(item1);
            Console.WriteLine(backpack.V);


            //task 3
            int[] a = { -11, -2, 3, 4, 5, 6, 7, 8, 9, 10, 7 };
            Mass kol = (int[] x) =>
            {
                int sum = 0;

                foreach (int item in x)
                {
                    if (item % 7 == 0)
                    {
                        sum++;
                    }
                }
                return sum;
            };
            Mass Plus = (int[] x) =>
            {
                int sum = 0;

                foreach (int item in x)
                {
                    if (item > 0)
                    {
                        sum++;
                    }
                }
                return sum;
            };

            Mass Otricatel = (int[] x) =>
            {
                int sum = 0;
                bool unique = true;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] < 0)
                    {
                        for (int z = 0; z < x.Length; z++)
                        {
                            if (i != z)
                            {
                                x[i] = x[z];
                                unique = false;
                            }
                        }

                    }
                    if (unique)
                    {
                        sum++;
                    }
                }
                return sum;
            };
            Console.WriteLine("Chisla kratni 7" + kol(a));
            Console.WriteLine("Chisla Polozhitelni " + Plus(a));
            Console.WriteLine("Chisla Otrizatel unique " + Otricatel(a));


            Text cont = (string text, string word) =>
            {
                return text.Contains(word);
            };


        }

        delegate int Mass(int[] x);
        delegate bool Text(string text, string word);
    }

}
