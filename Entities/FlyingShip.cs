﻿using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class FlyingShip : AirV
    {

        public FlyingShip()
        {
            Name = "Летучий корабль";
            Speed = 120;
            Acceleration = 700;
        }

        public FlyingShip(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
            Acceleration = 700;
        }


    }
}
