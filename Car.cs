using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Car : Vehicle
    {
        private int MaxPassengers;
        private int CurrentPassengers;

        public Car(int cp, double cf, FuelType f)
        {
            MaxPassengers = 5;
            FuelTankVolume = 60;
            Fuel = f;

            if (cp <= MaxPassengers)
            {
                CurrentPassengers = cp;
            }
            else
            {
                throw new Exception("Too many passengers");
            }

            if (cf < FuelTankVolume)
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
            return String.Format($"Current passengers: {CurrentPassengers}, Current fuel: {CurrentFuel} l");
        }
    }
}
