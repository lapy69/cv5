using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Vehicle
    {
        public enum FuelType { Petrol_fuel, Oil_fuel };
        protected int FuelTankVolume;
        protected double CurrentFuel;
        protected FuelType Fuel;
        Radio radio = new Radio();
                
        public void AddFuel(FuelType ft, double value)
        {
            if (Fuel == ft)
            {
                if (CurrentFuel + value <= FuelTankVolume)
                {
                    CurrentFuel = CurrentFuel + value;
                }
                else
                {
                    throw new Exception("Fuel tank doesn´t have enough space");
                }
            }
            else
            {
                throw new Exception("Wrong fuel type");
            }
        }

        public void RadioTurnOn(bool a)
        {
            radio.TurnOn(a);
        }

        public void NewItemInList(int a, double freq)
        {
            radio.SetFrequencyToList(a, freq);
        }

        public void SetRadio(int cislo)
        {
            radio.ChooseStation(cislo);
        }

        public void DisplayRadio()
        {
            Console.WriteLine(radio);
        }
    }
}
