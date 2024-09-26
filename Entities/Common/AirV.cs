using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Entities.Common
{
    internal class AirV : Vehicle
    {
        protected virtual double Acceleration { get; set; }
        public override double RaceTime(double distance)
        {
            if (distance <= 0) throw new ArgumentException("Error in distance ( distance must be 0 or greater )");

            double AccelerationCoef = 1 + Math.Log(distance + 1) / Acceleration;


            return distance / (Speed * AccelerationCoef);
        }

    }
}
