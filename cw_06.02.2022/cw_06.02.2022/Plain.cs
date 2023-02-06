using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Plain
    {
        private string name;
        private string manufacturer;
        private string createdYear;
        private string type;

        public string Name { get { return name; } set { name = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string CreatedYear { get { return createdYear; } set { createdYear = value; } }
        public string Type { get { return type; } set { type = value; } }

        public Plain()
        {
            name = string.Empty;
            manufacturer = string.Empty;
            createdYear = string.Empty;
            type = string.Empty;
        }

        public Plain(string name, string manufacturer, string createdYear, string type)
        {
            Name = name;
            Manufacturer = manufacturer;
            CreatedYear = createdYear;
            Type = type;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nManufacturer : {Manufacturer}\nCreatedYear : {CreatedYear}\nType : {Type}\n";
        }
    }
}
