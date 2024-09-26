using RaceSimulator.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Races
{
    internal class Race
    {
        protected double Distance { get; set; }     // probaj sa private i onda preko konstruktora;
        protected List<Vehicle> vehicles = new List<Vehicle>();

        public Race() { }
        public Race(double distance)
        {
            Distance = distance;
        }
        virtual public void RegisterV(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public Vehicle BeginRace()
        {
            Vehicle FastestVehicle;
            double FastestVehicleTime;
            double time;

            FastestVehicleTime = vehicles[0].RaceTime(Distance);
            FastestVehicle = vehicles[0];
            //Console.WriteLine($"Vozilo {vehicles[0].Name} je zavrsilo za {FastestVehicleTime}");

            for (int i = 1; i < vehicles.Count; i++)
            {
                time = vehicles[i].RaceTime(Distance);
                // Console.WriteLine($"Vozilo {vehicles[i].Name} je zavrsilo za {time}");

                if (time < FastestVehicleTime)
                {
                    FastestVehicleTime = time;
                    FastestVehicle = vehicles[i];
                }
            }

            Console.WriteLine($" Победитель нашей гонки это ->   {FastestVehicle.Name} ");
            return FastestVehicle;
        }


    }
}
