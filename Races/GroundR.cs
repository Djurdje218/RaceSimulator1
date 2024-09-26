using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Races
{
    internal class GroundR : Race
    {
        public GroundR(double distance)
        {
            Distance = distance;
        }

        public override void RegisterV(Vehicle vehicle)
        {
            if (vehicle is GroundV groundV)
            {
                vehicles.Add(groundV);
            }
            else throw new InvalidOperationException("Эта гонка только для наземных средств");

        }
    }
}
