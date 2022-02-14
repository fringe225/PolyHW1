using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    internal class Bycle : Vehicle
    {

        public Bycle(string brand, string color, double milliage) : base(brand, color, milliage)
        {
           
        }
        public override void Drive(double value)
        {
            Milliage += value;
        }

        public override void ShowInfo()
        {
            Console.Write("\nIt is a Bycle Info:\n");
            base.ShowInfo();
            Console.WriteLine();
        }
    }
}
