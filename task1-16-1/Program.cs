using System;


namespace task1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.WriteLine("plz insert your name :");
            string name = Console.ReadLine();
            Console.WriteLine("welcome" + name);
            //part 2
            double average = 80.5;
            string major = "computer engineering";
            char character = 'A';
            bool status = true;
            int age = 23;
            const int size = 5;
            Console.WriteLine("average is " + average);
            Console.WriteLine("major is " + major);
            Console.WriteLine("character is " + character);
            Console.WriteLine("stutus is " + status);
            Console.WriteLine("age is " + age);
            Console.WriteLine("size is " + size);
            //part 3
            string[] cars = { "BMW", "Camry", "Merceds", "IONIC" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("the length of the array is :" + cars.Length);
            //part 4
            Console.WriteLine("plz insert your info ");
            Console.Write("First Name :");
            string Fname = Console.ReadLine();
            Console.Write("Last Name :");
            string Lname = Console.ReadLine();
            Console.Write("Your Year of Birth :");
            string year = Console.ReadLine();
            Console.WriteLine(Fname + " " + Lname + " " + year);
            //part 5
            string[] numbers = new string[5];
            Console.WriteLine("plz insert 5 numbers");

            //string num;
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Console.ReadLine(); ;

            }
            Console.Write("Elements in array are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "");

            }









        }
    }
}
