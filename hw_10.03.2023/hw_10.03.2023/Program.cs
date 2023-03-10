using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Homework
{
    [Serializable]
    [DataContract]
    public class Device
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Manufacturer { get; set; }

        [DataMember]
        public decimal Cost { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = null;
            XmlSerializer serializer = null;
            DataContractJsonSerializer jsonFormatter = null;
            Device d=new Device();

            d = new Device { Name = "Телефон", Manufacturer = "Apple", Cost = 999 };
            
            stream = new FileStream("../../data.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(Device));
            serializer.Serialize(stream, d);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");

            stream = new FileStream("../../data.json", FileMode.Create);
            jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            jsonFormatter.WriteObject(stream, d);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
    }
}
