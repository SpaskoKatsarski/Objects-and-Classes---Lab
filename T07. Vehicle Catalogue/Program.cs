using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }
        
        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePowers { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>(); // Always initialize !!!!!
            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogItems = new Catalog();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int thirdDefinition = int.Parse(data[3]);

                if (type == "Car")
                {
                    Car currentCar = new Car();

                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePowers = thirdDefinition;

                    catalogItems.Cars.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck();

                    currentTruck.Brand = brand;
                    currentTruck.Model = model;
                    currentTruck.Weight = thirdDefinition;

                    catalogItems.Trucks.Add(currentTruck);
                }

                input = Console.ReadLine();
            }

            if (catalogItems.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                // print the ordered cars:
                List<Car> orderedCars = catalogItems.Cars.OrderBy(car => car.Brand).ToList();

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePowers}hp");
                }
            }

            if (catalogItems.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                List<Truck> orderedTrucks = catalogItems.Trucks.OrderBy(truck => truck.Brand).ToList();

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
