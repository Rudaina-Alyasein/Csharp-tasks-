using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class vehicle
    {
        string brand;
       int model;
        public string Brand
        {
            set
            {
                brand = value;
            }
            get
            {
                return brand;
            }
        }
        public int Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
        public vehicle()
        {
            this.brand = "camry";
            this.model = 2025;
        }
        public vehicle(string brand, int model)
        {
            this.brand = brand;
            this.model = model;
        }
        public void print()
        {
            Console.WriteLine("Vehicle is starting");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand},Model: {model} ");
        }
    }
    public class car:vehicle
    {
        int numberOfDoors;
        public  int NumberOfDoors
        {
            set
            {
                numberOfDoors = value;

            }
            get
            {
                return numberOfDoors;
            }
        }
        public car(string brand, int model,int numberOfDoors) :base(brand,model)
        {
           Brand = brand;

           Model = model;
            this.numberOfDoors = numberOfDoors;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle v1 = new vehicle();
            v1.Brand = "merceds";
            v1.Model= 2024;
            v1.print();
            v1.DisplayInfo();
            car c1 = new car("IONIC",2024,2);
            c1.DisplayInfo();

        }
    }
}
