using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{

    public class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Cost { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание массивов устройств
            Device[] array1 = {
            new Device { Name = "Телефон", Manufacturer = "Apple", Cost = 999 },
            new Device { Name = "Ноутбук", Manufacturer = "Dell", Cost = 1500 },
            new Device { Name = "Планшет", Manufacturer = "Samsung", Cost = 600 }
        };

            Device[] array2 = {
            new Device { Name = "Телефон", Manufacturer = "Samsung", Cost = 799 },
            new Device { Name = "Телевизор", Manufacturer = "LG", Cost = 1200 },
            new Device { Name = "Ноутбук", Manufacturer = "Dell", Cost = 1200 }
        };

            // Разница массивов
            var diffArray = array1.Except(array2, new DeviceComparer());

            Console.WriteLine("Разница массивов:");
            foreach (var device in diffArray)
            {
                Console.WriteLine($"{device.Name} ({device.Manufacturer}): {device.Cost}$");
            }

            // Пересечение массивов
            var intersectArray = array1.Intersect(array2, new DeviceComparer());

            Console.WriteLine("\nПересечение массивов:");
            foreach (var device in intersectArray)
            {
                Console.WriteLine($"{device.Name} ({device.Manufacturer}): {device.Cost}$");
            }

            // Объединение массивов
            var unionArray = array1.Union(array2, new DeviceComparer());

            Console.WriteLine("\nОбъединение массивов:");
            foreach (var device in unionArray)
            {
                Console.WriteLine($"{device.Name} ({device.Manufacturer}): {device.Cost}$");
            }
        }

        // Класс, реализующий интерфейс IEqualityComparer для сравнения устройств по производителю
        class DeviceComparer : IEqualityComparer<Device>
        {
            public bool Equals(Device x, Device y)
            {
                return x.Manufacturer == y.Manufacturer;
            }

            public int GetHashCode(Device device)
            {
                return device.Manufacturer.GetHashCode();
            }
        }
    }

}
