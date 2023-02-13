// Демонстрация порядка выполнения конструкторов.
using System;

namespace Test
{
    class MainClass
    {
        public static void Main()
        {
            Human human= new Human("Vlad", 19);
            Console.WriteLine(human);
            Student student = new Student(human.Name, human.Age, "Step");
            Console.WriteLine(student);
            Teacher teacher = new Teacher(human.Name, human.Age, "Step");
            Console.WriteLine(teacher);
        }
    }
}
