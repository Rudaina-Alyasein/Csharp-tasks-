using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace task4_21_1
{
    public class Student
    {
        string student_name;
        int student_age;
        int studentID;
        public const int minAge = 18;
        public const int maxAge = 40;

        public string Email { get; set; }
        
        public string Student_name
        {
            set
            {
                student_name = value;
            }
            get
            {
                return student_name;
            }
        }
        public int Student_age
        {
            set
            {
                if (minAge<=value&& value <= maxAge)
                {
                    student_age = value;
                }
                else
                {
                    Console.WriteLine($"plz pass age between {minAge} and {maxAge} ");
                }

            }
            get
            {
                return student_age;
            }
        }
        public int StudentID
        {
            set
            {
                studentID = value;
            }
            get
            {
                return studentID;
            }
        }
        public Student()
        {
            student_name = null;
            student_age = 0;
            studentID = 0;



        }
        ~Student()
        {
            Console.WriteLine($"object {student_name} destroyed");
        }
        public Student(string student_name, int student_age, int studentID)
        {
            this.student_name = student_name;
            this.student_age = student_age;
            this.studentID = studentID;


        }
        public void getDetails()
        {
            Console.WriteLine("StudentName:"+student_name +" StudentAge :"+ student_age +" studentID : "+studentID);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("plz insert the following info:");
            Console.WriteLine("Student_name :");
            s1.Student_name = Console.ReadLine();
            Console.WriteLine("Student_age:");
            s1.Student_age = int.Parse(Console.ReadLine());
            Console.WriteLine("StudentID:");
            s1.StudentID = int.Parse(Console.ReadLine());
            s1.Email = "rudaina alyasein@gmail.com";
            s1.getDetails();
            Student s2 = new Student();
            Console.WriteLine("plz insert the following info:");
            Console.WriteLine("Student_name :");
            s2.Student_name = Console.ReadLine();
            Console.WriteLine("Student_age:");
            s2.Student_age = int.Parse(Console.ReadLine());
            Console.WriteLine("StudentID:");
            s2.StudentID = int.Parse(Console.ReadLine());
            s2.Email = "rudaina alyasein@gmail.com";
            s2.getDetails();

            Student s3 = new Student("sara", 26, 10);
            s3.getDetails();
            //1-	What is class ? blueprint of object , structure to write code , contains attributes & methods
            //2-	What is object? instance of class 
            //3 - Difference between class && object?
            //Class is a detailed description, the definition, and the template of what an object will be
            //Object is an instance of a class. All data members and member functions of the class can be accessed with the help of objects.When a class is defined, no memory is allocated, but memory is allocated when it is instantiated
            //4 - Mention the OOP Principles:
            //1.Encapsulation 2.Abstract 3.Polymorphism 4.inheritance
            //5 - What is property?
            //We use property to assign private Data ,property reads and writes are(usually) translated to 'getter' and 'setter' method calls
            //6 - What is field?
            //A field is a member variable that is declared within a class or struct and is used to hold data for an instance of a class/objects of a class.
            //7 - What is constructor? Special function , we use it to assign initial value for attributes .
            //8 - What is encapsulation? Encapsulation is the concept of bundling data(fields) and methods(functions) that operate on that data into a single unit, typically a class. It restricts direct access to some of the object's components, which is achieved using access modifiers.





    }
    }
}
