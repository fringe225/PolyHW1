using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    internal class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }


        public Car(string brand,string color,double milliage,double fuelcp,double currentFuel,double fuel1km) : base(brand, color, milliage)
        {
            FuelCapacity = fuelcp;
            CurrentFuel = currentFuel;
            FuelFor1km = fuel1km;
        }
        public override void Drive(double value)
        {
            if(CurrentFuel >= (value *FuelFor1km))
            {
                CurrentFuel-=(value*FuelFor1km);
                Milliage += value;
            }
            else
            {
                Console.WriteLine("You Don't Have Enough Fuel! ");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($"Fuel Capacity - {FuelCapacity}\nCurrent Fuel - {CurrentFuel}\nFuel for 1 km - {FuelFor1km}\n");
        }
    }
}
