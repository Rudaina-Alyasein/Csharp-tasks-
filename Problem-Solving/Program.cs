using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem1
            int h = 5;
            string Current = "*";
            for (int i = 1; i <= h; i++)
            {
                for (int k = 1; k <= h - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Current);
                }
                Console.WriteLine();
            }
            //problem2
            string String_number = "123456";
            int newNumber = int.Parse(String_number);
            int Sum = 0;
            int [] numberOfArray = new int[String_number.Length];
            string Reversed_number = "";
            
            while (newNumber != 0)
            {
                Sum += newNumber % 10;
                Reversed_number += newNumber % 10;
                newNumber = newNumber / 10;
               
            }
            Console.WriteLine(Sum);
            Console.WriteLine($"the number after reversed is : {int.Parse(Reversed_number)}");








        }


    }
}
