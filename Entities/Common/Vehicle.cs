﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.Entities.Common
{
    public abstract class Vehicle(string name)
    {
        public string Name { get; set; } = name; // PODESTNIK promeni oba na protected i dodaj konstruktore
        protected double Speed { get; set; }

        public abstract double RaceTime(double distance);


    }
}
