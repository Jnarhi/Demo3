using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T4
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name : "+ Name);
            Console.WriteLine("Speed : "+ Speed);
            Console.WriteLine("Tyres : "+ Tyres);
        }

        // method returns Vehicle data
        public override string ToString()
        {
            return "Name: " + Name + "Speed: " + Speed + "Tyres: " + Tyres;
        }
    }
}
