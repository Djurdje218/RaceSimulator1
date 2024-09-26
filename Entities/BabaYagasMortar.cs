using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceSimulator.Entities
{
    internal class BabaYagasMortar : GroundV
    {
        public BabaYagasMortar()
        {
            Name = "Ступа Бабы Яги";
            Speed = 80;
            MaxRaceTime = 3;
            RestPeriod = 8;


        }
        public BabaYagasMortar(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
            MaxRaceTime = 3;
            RestPeriod = 8;

        }
    }
}
