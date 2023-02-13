// Демонстрация порядка выполнения конструкторов.
using System;
using System.Security.Cryptography;
using Task1;
using Task2;

namespace Lab
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("\t///TASK1///\n");
            Human[] people = new Human[5];
            people[0] = new Builder("Vlad", 19, 1000, "BuildComp");
            people[1] = new Pilot("Vlad", 19, 1000, "Boing");
            people[2] = new Sailor("Vlad", 19, 1000, "Mariya");
            people[3] = new Teacher("Vlad", 19, "Step");
            people[4] = new Student("Vlad", 19, "Step");

            foreach (var person in people)
            {
                Console.WriteLine(person + "\n");
            }

            Console.WriteLine("\t///TASK2///\n");
            Passport[] pp = new Passport[2];
            pp[0] = new Passport("Vlad", "Karlinskiy", "M", "Uraine", "23.01.2022", "23.01.2045", "23.01.2004", "5001", "Odesa/Ukraine");
            pp[1] = new ForeignPassport("Vlad", "Karlinskiy", "M", "Uraine", "23.01.2022", "23.01.2045", "23.01.2004", "5001", "Odesa/Ukraine", "P", "UKR");


            foreach (var el in pp)
            {
                Console.WriteLine(el + "\n");
            }
        }
    }
}
