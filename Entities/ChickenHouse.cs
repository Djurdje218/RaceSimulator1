using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class ChickenHouse : GroundV
    {
        public ChickenHouse()
        {
            Name = "Избушка на курьих ножках";
            Speed = 60;
            MaxRaceTime = 4;
            RestPeriod = 10;
        }

        public ChickenHouse(string Name, double Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
            MaxRaceTime = 4;
            RestPeriod = 10;
        }

    }
}
