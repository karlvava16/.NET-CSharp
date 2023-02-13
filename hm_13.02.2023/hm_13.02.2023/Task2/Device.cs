using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Device
    {
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
    }

    class Kettle : Device
    { 

        public override void Sound()
        {
            Console.WriteLine("SHHHHHHHHH PAK");
        }
        public override void Show()
        {
            Console.WriteLine("Kettle");
        }

        public override void Desc()
        {
            Console.WriteLine("Kettle is a container or device in which water is boiled, having a lid, spout, and handle.");
        }
    }

    class Microwave : Device
    {

        public override void Sound()
        {
            Console.WriteLine("DZZN");
        }
        public override void Show()
        {
            Console.WriteLine("Microwave");
        }

        public override void Desc()
        {
            Console.WriteLine("Microwave is an electromagnetic wave with a wavelength in the range 0.001–0.3 m, shorter than that \n" +
                "of a normal radio wave but longer than those of infrared radiation. Microwaves are used in radar, in communications, \n" +
                "and for heating in microwave ovens and in various industrial processes.");
        }
    }

    class Car : Device
    {

        public override void Sound()
        {
            Console.WriteLine("IEEEE DREN DEN DEN");
        }
        public override void Show()
        {
            Console.WriteLine("Car");
        }

        public override void Desc()
        {
            Console.WriteLine("Car is a four-wheeled road vehicle that is powered by an engine and is able to carry a small number of people.");
        }
    }

    class Steamboat : Device
    {

        public override void Sound()
        {
            Console.WriteLine("UU UUUU");
        }
        public override void Show()
        {
            Console.WriteLine("Steamboat");
        }

        public override void Desc()
        {
            Console.WriteLine("Steamboat is a boat driven by steam power. specifically : a shallow-draft vessel used on inland waterways.");
        }
    }
}
