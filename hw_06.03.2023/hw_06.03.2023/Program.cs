using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Homework
{
    internal class Program
    {
        static void Task1()
        {
            XmlTextWriter xtr = null;
            xtr = new XmlTextWriter("../../Orders.xml", System.Text.Encoding.Unicode);
            xtr.Formatting = Formatting.Indented;

            List<Order> orders = new List<Order>();
            orders.Add(new Order { Id = 551212345, Name = "Macbook", Description = "Apple device" });
            orders.Add(new Order { Id = 551252345, Name = "Asus zenbook", Description = "Asus device" });

            xtr.WriteStartDocument();
            xtr.WriteStartElement("orders");

            foreach (Order order in orders)
            {

                xtr.WriteStartElement("order");
                xtr.WriteAttributeString("id", order.Id.ToString());
                xtr.WriteElementString("name", order.Name);
                xtr.WriteElementString("description", order.Description);
                xtr.WriteEndElement();
            }
            xtr.WriteEndElement();
            xtr.Close();

        }
        static void Task2()
        {
            List<Order> orders = new List<Order>();
            try
            {
                XmlTextReader reader = null;
                reader = new XmlTextReader("Orders.xml");
                string str = null;
                while (reader.Read()) // Считывает следующий узел из потока
                {


                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "order")
                    {
                        orders.Add(new Order());
                        reader.MoveToNextAttribute();
                        orders[orders.Count - 1].Id = Convert.ToInt32(reader.Value);
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                    {
                        reader.Read();
                        orders[orders.Count - 1].Name = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "description")
                    {
                        reader.Read();
                        orders[orders.Count - 1].Description = reader.Value;
                    }

                }

                foreach (Order order in orders)
                {
                    Console.WriteLine(order);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }
    }
}
