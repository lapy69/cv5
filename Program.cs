using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(5, 4, 20, 60, Vehicle.FuelType.Petrol_fuel);
            Truck truck = new Truck(2000, 200, 130,200, Vehicle.FuelType.Oil_fuel);

            Console.WriteLine(car);
            Console.WriteLine(truck);

            car.RadioTurnOn(true);
            car.NewItemInList(1,97.8);
            car.SetRadio(1);
            car.DisplayRadio();

            truck.RadioTurnOn(true);
            truck.NewItemInList(1, 96.2);
            truck.NewItemInList(2, 101.1);
            truck.SetRadio(2);
            truck.DisplayRadio();

            Console.ReadLine();
        }
    }
}
