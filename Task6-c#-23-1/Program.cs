using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_24_1
{
    public class calculator
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine($"the sum of two integer number , {num1} & {num2} is {num1 + num2}");
        }
        public void add(int num1, int num2, int num3)
        {
            Console.WriteLine($"the sum of two integer number , {num1} & {num2}&{num3} is {num1 + num2 + num3}");
        }
        public void add(double num1, double num2)
        {
            Console.WriteLine($"the sum of two double number , {num1} & {num2} is {num1 + num2}");
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape.");

        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }
    public abstract class Animal
    {
        public abstract void makeSound();
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }
    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks.");
        }

    }
    public class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }
    public interface IPlayable
    {
        void play();
    }
    public class Guitar : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar.");
        }

    }
    public class Piano : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            c1.add(2, 3);
            c1.add(2, 3, 8);
            c1.add(2.8, 3.2);
            Shape circle1 = new Circle();
            circle1.Draw();
            Shape Rectangle1 = new Rectangle();
            Rectangle1.Draw();
            IPlayable g1 = new Guitar();
            g1.play();
            IPlayable p1 = new Piano();
            p1.play();


        }
    }
}
