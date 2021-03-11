using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Truck : Vehicle
    {
        private int MaxCargo;
        private double CurrentCargo;
        
        public Truck(double cc, double cf, FuelType f):base(cf, f)
        {
            MaxCargo = 1000;
            FuelTankVolume = 200;
            Fuel = f;

            if (cc <= MaxCargo)
            {
                CurrentCargo = cc;
            }
            else
            {
                throw new Exception("Overweight");
            }    

            if(cf<FuelTankVolume)
            {
                CurrentFuel = cf;
            }
            else
            {
                throw new Exception("Too much fuel");
            }
        }

        public override string ToString()
        {
            return String.Format($"Current cargo: {CurrentCargo} kg, Current fuel: {CurrentFuel} l");
        }
    }
}
