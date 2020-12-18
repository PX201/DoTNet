using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var aiman = new Student();

            Console.Write("enter your name :");
            aiman.FirstName = Console.ReadLine();

            Console.Write("Enter your last name : ");
            aiman.LastName = Console.ReadLine();

            Console.Write("enter your email : ");
            aiman.EMail = Console.ReadLine();

            Console.Write("enter your phone number : ");
            aiman.PhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(aiman);
           


        }
    }
}
