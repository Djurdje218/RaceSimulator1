using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Races
{
    internal class AirR : Race
    {
        public AirR(double distance)
        {
            Distance = distance;
        }
        public override void RegisterV(Vehicle vehicle)
        {
            if (vehicle is AirV airV)
            {
                vehicles.Add(airV);
            }
            else throw new InvalidOperationException("Эта гонка только для воздушных транспортных средств");

        }
    }
}
