using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }

        public double Milliage { get; set; }

        public Vehicle(string brand,string color,double milliage)
        {
            Color= color;
            Brand= brand;
            Milliage=milliage;
        }


        public virtual void ShowInfo()
        {
            Console.Write($"Brand - {Brand}\nColor - {Color}\nMillage - {Milliage}\n");
        }

        public abstract void Drive(double value);
    }
}
