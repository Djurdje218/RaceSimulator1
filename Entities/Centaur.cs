﻿using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class Centaur : GroundV
    {
        public Centaur()
        {
            Name = "Кентавр";
            Speed = 85;
            MaxRaceTime = 6;
            RestPeriod = 8;
        }
        public Centaur(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
            MaxRaceTime = 6;
            RestPeriod = 8;
        }
    }
}
