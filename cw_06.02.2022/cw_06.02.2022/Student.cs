using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
     public class Student
    {
        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student() 
        {
            name = null; 
            age = 0;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public override string ToString() 
        {
            return $"Name : {name}\nAge: {age}\n";
        }
    }
}
