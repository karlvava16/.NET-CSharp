using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student : Human
    {
        public string University { get; set; }
        public Student(string name, int age, string university) : base(name, age)
        {
            University = university;
        }
        public override string ToString()
        {
            return "|Student|\n" + base.ToString() + $"\tUniversity: {University}";
        }
    }
}
