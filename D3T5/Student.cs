using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T5
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public void GetOld()
        {
            Age++;
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name + "Gender: " + Gender + "Age: " + Age + "Hobby: " + Hobby);
        }
    }
}
