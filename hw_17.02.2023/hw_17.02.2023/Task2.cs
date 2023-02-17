using System;

namespace Homework
{
    delegate void Task2D();
    abstract class Task2
    {

        public static void ShowTime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.TimeOfDay);
        }
        public static void ShowDate()
        {

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.Date);

        }

        public static void ShowWeekDay()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }

        public static void ShowSTriangle()
        {
            Console.WriteLine("S triangle");
        }
        public static void ShowSRecktangle()
        {
            Console.WriteLine("S Recktangle");
        }
    }
}