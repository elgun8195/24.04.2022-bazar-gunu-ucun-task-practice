using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student= new Student("Programming");
            student.Fullname = "Elgun";
            Student student2 = new Student("Design")
            {
                Fullname = "Yusif Quluyev",
                
            };

            Student student3 = new Student("Design")
            {
                Fullname = "Full Name",

            };
            Student student4 = new Student("Programming");
            student.Fullname = "Elugn";
            Console.WriteLine(student4.Groupname);
            Console.WriteLine(student2.Groupname);
            
        }
    }
}
