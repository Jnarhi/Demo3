using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3T4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 4
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Lada";
            vehicle.Speed = 80;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();
        }
    }
}
