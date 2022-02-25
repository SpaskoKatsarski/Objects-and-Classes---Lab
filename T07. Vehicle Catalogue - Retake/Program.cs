using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Vehicle_Catalogue___Retake
{
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, double horsePowers)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePowers = horsePowers;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePowers { get; set; }
    }

    class Catalog
    {
        // Always add this:
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = null;
            this.Trucks = null;
        }
        //

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                // command format: {type}/{brand}/{model}/{horse power / weight}

                string[] info = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = info[0];

                string brand = info[1];
                string model = info[2];
                double thirdParameter = double.Parse(info[3]);

                if (type == "Car")
                {
                    Car currentCar = new Car(brand, model, thirdParameter);
                    cars.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck(brand, model, thirdParameter);
                    trucks.Add(currentTruck);
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();

                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePowers}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                List<Truck> sortedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();

                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
