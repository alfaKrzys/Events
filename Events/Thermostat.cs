using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged = delegate { };

        private float _CurrentTemperature;

        public float CurrentTemperature
        {
            get
            {
                return _CurrentTemperature;
            }

            set
            {
                if (_CurrentTemperature != value)
                {
                    _CurrentTemperature = value;
                    TemperatureChanged(this, new TemperatureChangedEventArgs(value));
                }
            }
        }
    }
}
