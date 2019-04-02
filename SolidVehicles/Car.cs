using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    class Car : IVehicle, ILand
    {
        public string Name { get; set; } = "Car";
        public string Type { get; set; } = "Land";
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; } = 1.0;
        public double MaxLandSpeed { get; set; } = 68;

        public void Drive()
        {
            Console.WriteLine("This Bike Lights The Street On Fire");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
