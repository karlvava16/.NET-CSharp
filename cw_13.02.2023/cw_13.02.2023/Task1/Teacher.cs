using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Teacher : Human
    {
        public string University { get; set; }
        public Teacher(string name, int age, string university) : base(name, age)
        {
            University = university;
        }
        public override string ToString()
        {
            return "|Teacher|\n" + base.ToString() + $"\tUniversity: {University}";
        }
    }
}
