using System;
using System.Collections.Generic;
using System.Linq;


namespace task3_c_
{
    internal class Program

    {
        static int[] PrimeNum(int m, int n)
        {

            int count = 0;
            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }


            int[] arrya_prime = new int[count];
            int index = 0;


            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    arrya_prime[index++] = i;
                }
            }

            return arrya_prime;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //class
        public class Room
        {
            int roomNum;
            string roomType;
            double pricePerNight;
            Boolean IsBooked;
            const string HotelName = "Grand Stay Hotel";
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



        }

        static void Main(string[] args)
        {
            //part1
            Console.WriteLine("plz insert integer number and determine it if odd or even");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is even ");
            }
            else
            {
                Console.WriteLine($" The number {num} is odd ");
            }
            //part2
            Console.WriteLine("plz insert five numbers and return the second smallest number:");
            int[] array_numbers = new int[5];
            for (int i = 0; i < array_numbers.Length; i++)
            {
                array_numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array_numbers.Length - 1; i++)
            {
                for (int j = 0; j < array_numbers.Length - 1 - i; j++)
                {
                    if (array_numbers[j] > array_numbers[j + 1])
                    {

                        int temp = array_numbers[j];
                        array_numbers[j] = array_numbers[j + 1];
                        array_numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"the second smallest number is :{array_numbers[1]}");

            //part 3

            Console.WriteLine("Plz insert random integer number and calculate factorial from it :");
            int Num1 = int.Parse(Console.ReadLine());
            int Factorial_Number = 1;
            for (int i = Num1; i > 0; i--)
            {
                Factorial_Number *= i;
            }
            Console.WriteLine($"Factorial number of {Num1} is {Factorial_Number}");
            //part 4 
            int[] Prime_numbers = PrimeNum(10, 30);
            Console.WriteLine("the prime numbers between 10 & 30 are :");
            foreach (int Prime in Prime_numbers)
            {
                Console.WriteLine(Prime);
            }
            //part5
            int[] numbers = { 2, 6, 5, 4, 9, -8, 10 };
            int max_num = numbers[0];
            foreach (int Number in numbers)
            {
                if (Number > max_num)
                {
                    max_num = Number;
                }
            }
            Console.WriteLine($"the max nuber in array is : {max_num}");
            //part 6
         
            int currentNumber = 1;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
            }
            //part 7
            int height = 5;
            string CurrentSymbol = "*";
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(CurrentSymbol + " ");
                }
                Console.WriteLine();
            }
            //part8
            int[] arrayOfnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumOfEven = 0;
            int sumOfOdd = 0;
            foreach (int number in arrayOfnumbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEven += number;
                }
                else
                    sumOfOdd += number;
            }

            Console.WriteLine($"the saummation of even number is : {sumOfEven}");
            Console.WriteLine($"the saummation of odd number is : {sumOfOdd}");
            //part9
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 3, 4, 5, 6 };
            int count = 0;

            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2.Contains(arr1[i]))
                {
                    count++;

                }
            }
            int[] CommonElements = new int[count];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2.Contains(arr1[i]))
                {
                    CommonElements[index++] = arr1[i];

                }
            }
            Console.Write("the common elements in array are:");
            foreach (int ele in CommonElements)
            {
                Console.Write(ele + " ");
            }
            //part 10
            List<Room> rooms = new List<Room>();
            Console.WriteLine("Welcome to the Hotel Reservation System, Please enter the information below.");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Room {i + 1}:");

                Console.WriteLine("Room number:");
                int roomNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Room Type: Please select one of these types: single, double, suite");
                string roomType = Console.ReadLine();

                Console.WriteLine("Price Per Night:");
                double pricePerNight = double.Parse(Console.ReadLine());

                Console.WriteLine("Is Booked? (True or False):");
                bool isBooked = bool.Parse(Console.ReadLine());

                Room room = new Room(roomNum, roomType, pricePerNight, isBooked);
                rooms.Add(room);
            }

            Console.WriteLine("\nAll Rooms Information:");
            foreach (Room room in rooms)
            {
                room.print();
                Console.WriteLine();
            }








        }


    }


}

