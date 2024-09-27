using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class Broom : AirV
    {
        public Broom() : base("Метла")
        {
            Speed = 110;
            Acceleration = 600;

        }

        public Broom(string Name, double speed) : base(Name)
        {
            this.Speed = speed;
            Acceleration = 600;
        }

    }
}
