
using System;


namespace Lab04
{
    class Program
    {
        public static void Main(string[] arg)
        {
            var student = new StudentExtended();
            Console.Write("Name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("LastName: ");
            student.LastName = Console.ReadLine();

            Console.Write("PhoneNumber: ");
            student.PhoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            student.EMail = Console.ReadLine();

            Console.WriteLine("Please Enter your Birthdate (exp 2020, 12,30)");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            student.BirthDate = inputtedDate;

            Console.WriteLine("Please Enter Date of your admission(exp 2018, 09,30)");
            DateTime inputtedDate2 = DateTime.Parse(Console.ReadLine());
            student.Admission = inputtedDate2;

            Console.WriteLine("Plese Enter your faculty name");
            student.Faculty = Console.ReadLine();

            Console.WriteLine("Plese Enter your specialty number");
            student.Specialty_number = Console.ReadLine();

            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }

    }
}