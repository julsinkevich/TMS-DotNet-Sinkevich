﻿using System;
using System.Collections.Generic;

namespace Homework_6.Models
{
    internal class FitnessTracker
    {
        public DateTime DateTime { get; set; }
        public int Steps { get; set; }
        public int Pulse { get; set; }
        public List<RunTracker> Run { get; set; }
        public int WaterCupCount { get; set; }
    }
}
