using Homework_6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6.Interfaces
{
    interface IFitness
    {
        public int GetSteps();
        public int GetPulse();
        public void Water();
        public void RunType();
    }
}
