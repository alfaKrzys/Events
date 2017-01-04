using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Heater
    {
        private float _Temperature;

        public Heater(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature
        {
            get
            {
                return _Temperature;
            }

            set
            {
                _Temperature = value;
            }
        }

        internal void TemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            if (e.NewTemperature < Temperature)
            {
                Console.WriteLine("Grzejnik pracuje");
            }
            else
            {
                Console.WriteLine("Grzejnik wyłączony");
            }
        }
    }
}
