using System;
using ClassTaxi;

namespace tugas
{
    class program
    {
        static void Main(string[] args)
        {
            // membuat ibjek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Naufal";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.InfoTaxi();
            taxi.PickUpPassenger();
            taxi.PickOffPassenger();

            Console.ReadKey();

        }
    }
}