using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class PumpkinCar : GroundV
    {
        public PumpkinCar() : base("Карета-тыква")
        {
            Speed = 70;
            MaxRaceTime = 5;
            RestPeriod = 7;
        }

        public PumpkinCar(string Name, double Speed) : base(Name)
        { 
            this.Speed = Speed;
            MaxRaceTime = 5;
            RestPeriod = 7;
        }
    }
}
