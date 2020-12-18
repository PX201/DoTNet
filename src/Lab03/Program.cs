using Lab01;
using System;
using System.Collections.Generic;
namespace Lab03
    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for make new Students list hit : 1\nFor view the student list hit : 2");
            var command = int.Parse(Console.ReadLine());

            var students = new List<Student>();
            if(command == 1)
            {
                Console.Write("Please enter number of student that u wanna register : ");
                var StudentNumber = int.Parse(Console.ReadLine());


                for(int i = 0; i < StudentNumber; i++)
                {
                    var std = new Student();
                    Console.WriteLine("iNFO FOR Student number : {0}",(i+1));

                    Console.Write("First Name : ");
                    std.FirstName = Console.ReadLine();

                    Console.Write("Last Name : ");
                    std.LastName = Console.ReadLine();

                    Console.Write("E-mail : ");
                    std.EMail = Console.ReadLine();

                    Console.Write("Phone number : ");
                    std.PhoneNumber = int.Parse(Console.ReadLine());

                    students.Add(std);
                }
                String[] lines = new string[students.Count];
                for(int i = 0; i < students.Count; i++)
                {
                    lines[i] = students[i].ToString();
                }
                System.IO.File.WriteAllLines("students.txt", lines);

            }
            else if(command == 2)
            {
                var input = System.IO.File.ReadAllLines("students.txt");
                foreach (var inp in input)
                {
                    var st = new Student();
                    var parts = inp.Split(',');
                    st.FirstName = parts[0].Split(':')[1].Trim();
                    st.LastName = parts[1].Split(':')[1].Trim();
                    st.EMail = parts[2].Split(':')[1].Trim();
                    st.PhoneNumber = int.Parse(parts[3].Split(':')[1]);
                    students.Add(st);
                }
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
                Console.ReadKey();

            }
            else { Console.WriteLine("U must hit other number please restart the programm amd try again >_<."); }
            Console.ReadKey();

        }
    }
}
