using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 5
            Student[] students = new Student[5];
            students[0] = new Student();
            students[0].Name = "Matti, ";
            students[0].Gender = "Male, ";
            students[0].Age = 21;
            students[0].Hobby = "Ice Hockey";

            students[1] = new Student();
            students[1].Name = "Saara, ";
            students[1].Gender = "Female, ";
            students[1].Age = 22;
            students[1].Hobby = "Drawing";

            students[2] = new Student();
            students[2].Name = "Viljo, ";
            students[2].Gender = "Male, ";
            students[2].Age = 20;
            students[2].Hobby = "Playing video games";

            students[3] = new Student();
            students[3].Name = "Jaakko, ";
            students[3].Gender = "Male, ";
            students[3].Age = 22;
            students[3].Hobby = "Playing in a band";

            students[4] = new Student();
            students[4].Name = "Henna, ";
            students[4].Gender = "Female, ";
            students[4].Age = 21;
            students[4].Hobby = "Reading";


            // Vanhentua
            for (int i=0; i<5;i++)
            {
                students[i].PrintData();
                students[i].GetOld();
            }
            Console.WriteLine("Next year: ");
            for (int i=0;i<5; i++)
            {
                students[i].PrintData();
            }
            Console.ReadLine();
        }
    }
}
