using Lab01;

using System;
using System.Collections.Generic;


namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            Console.Write("Enter number of student : ");
            var count = int.Parse(Console.ReadLine());
            

            for (int i = 0 ;i < count; i++)
            {
                Console.WriteLine("Student number "+(i+1));
                var student = new Student();

                Console.WriteLine("Name");
                student.FirstName = Console.ReadLine();
                student.LastName = Console.ReadLine();

                Console.WriteLine("Email");
                student.EMail = Console.ReadLine();

                Console.WriteLine("phone");
                student.PhoneNumber = int.Parse(Console.ReadLine());
                students.Add(student);



            }

           foreach(var student in students)
            {
                Console.WriteLine(student);
            }




        }
    }
}
