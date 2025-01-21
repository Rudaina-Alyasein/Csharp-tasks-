using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        public class Room
        {
            public int roomNum;
            public string roomType;
            public double pricePerNight;
            public Boolean IsBooked;
            public const string HotelName = "Grand Stay Hotel";
            public Room()
            {
                roomNum = 1;
                roomType = "Single";
                pricePerNight = 300;
                IsBooked = true;


            }
            public Room(int roomNum1, string roomType1, double pricePerNight1, Boolean IsBooked1)
            {
                roomNum = roomNum1;
                roomType = roomType1;
                pricePerNight = pricePerNight1;
                IsBooked = IsBooked1;


            }
            public void print()
            {
                Console.WriteLine($" room num:{roomNum}  room type: {roomType}  pricePerNight: {pricePerNight}  IsBooked: {IsBooked} Hotel Name:{HotelName}");
            }

            static void Main(string[] args)
            {
                Room room1 = new Room();
                room1.print();
               
                Console.WriteLine("Room number:");
                int roomNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Room Type: Please select one of these types: single, double, suite");
                string roomType = Console.ReadLine();

                Console.WriteLine("Price Per Night:");
                double pricePerNight = double.Parse(Console.ReadLine());

                Console.WriteLine("Is Booked? (True or False):");
                bool isBooked = bool.Parse(Console.ReadLine());
                Room room = new Room(roomNum, roomType, pricePerNight, isBooked);
                room.print();

            }
        }
    }
}
