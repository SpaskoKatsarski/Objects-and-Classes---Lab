using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Store_Boxes___Retake
{
    class Box
    {
        public Box(string serialNum, string name, int quantity, decimal priceForBox, decimal totalPrice)
        {
            this.SerialNumber = serialNum;
            this.ItemName = name;
            this.ItemQuantity = quantity;
            this.PriceForBox = priceForBox;
            this.TotalPrice = totalPrice;
        }

        public string SerialNumber { get; set; }

        public string ItemName { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }

        public decimal TotalPrice { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> products = new List<Box>();

            while (command != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = data[0];
                string itemName = data[1];
                int quantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                decimal totalPrice = quantity * itemPrice;

                Box currentBox = new Box(serialNumber, itemName, quantity, itemPrice, totalPrice);

                products.Add(currentBox);

                command = Console.ReadLine();
            }

            List<Box> sortedBox = products.OrderByDescending(product => product.TotalPrice).ToList();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
}
