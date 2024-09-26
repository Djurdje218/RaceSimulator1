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
        public Broom()
        {
            Name = "Метла";
            Speed = 110;
            Acceleration = 600;

        }

        public Broom(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
            Acceleration = 600;
        }

    }
}
