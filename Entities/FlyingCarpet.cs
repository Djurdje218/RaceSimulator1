using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class FlyingCarpet : AirV
    {
        public FlyingCarpet() : base("Ковер-самолет")
        {
            Speed = 100;
            Acceleration = 500;
        }

        public FlyingCarpet(string Name, double speed) : base(Name)
        {
            this.Speed = speed;
            Acceleration = 500;
        }

    }
}
