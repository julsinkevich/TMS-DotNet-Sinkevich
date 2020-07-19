﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6.Models
{
    class FitnessTracker
    {
        public DateTime DateTime { get; set; }
        public int Steps { get; set; }
        public int Pulse { get; set; }
        public List<RunTracker> Run { get; set; }
        public int WaterCupCount{ get; set; }
    }
}