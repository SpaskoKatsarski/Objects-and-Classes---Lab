using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Store_Boxes
{
    class Box
    {
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
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                // {Serial Number} {Item Name} {Item Quantity} {itemPrice}

                string[] data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Box box = new Box();

                box.SerialNumber = data[0];
                box.ItemName = data[1];
                box.ItemQuantity = int.Parse(data[2]);
                box.PriceForBox = decimal.Parse(data[3]);

                box.TotalPrice = box.ItemQuantity * box.PriceForBox;

                boxes.Add(box);

                line = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(x => x.TotalPrice).ToList();

            // {boxSerialNumber}
            // -- { boxItemName} – ${ boxItemPr ice}: { boxItemQuantity}
            // -- ${ boxPrice}

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
}
