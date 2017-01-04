using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class TemperatureChangedEventArgs : EventArgs
    {
        public float NewTemperature { get; set; }

        public TemperatureChangedEventArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }
}
