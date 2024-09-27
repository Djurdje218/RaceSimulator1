using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Entities.Common
{
    internal class GroundV(string name) : Vehicle(name)
    {
        protected int MaxRaceTime { get; set; }
        protected int RestPeriod { get; set; }

        // public GroundV() { }

        public override double RaceTime(double distance)
        {
            if (distance <= 0) throw new ArgumentException(" Error in distance ");

            double MoveTime = distance / Speed; // movement time without rest
            double RestCount = Math.Floor(MoveTime / MaxRaceTime);


            return RestPeriod * RestCount + MoveTime;

        }
    }
}
