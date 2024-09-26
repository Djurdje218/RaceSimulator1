using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class SevenLeageBoots : GroundV
    {
        public SevenLeageBoots()
        {
            Name = "Сапоги-скороходы";
            Speed = 90;
            MaxRaceTime = 4;
            RestPeriod = 5;
        }

        public SevenLeageBoots(string Name, double Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
            MaxRaceTime = 4;
            RestPeriod = 5;
        }
    }
}
