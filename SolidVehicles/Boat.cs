﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    class Boat : IWaterVehicle
    {
        public string Name { get; set; } = "Boat";
        public string Type { get; set; } = "Water";
        public int PassengerCapacity { get; set; } = 9;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; } = 1.0;
        public double MaxWaterSpeed { get; set; } = 60.2;

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
