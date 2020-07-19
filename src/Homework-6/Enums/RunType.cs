using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6.Enums
{
    public enum RunType
    {
        RunningWithAnAerobicPulseLoad=0,//пульс должен быть 115-125 ударов в минуту
        Jogging=1,//7-9 км в час 
        IntervalRun=2,//120 ударов в минуту когда перерыв 
        SprintRun=3//очень быстро маленькие дистанции 
    }
}
