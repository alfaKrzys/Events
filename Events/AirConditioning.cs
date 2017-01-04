using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class AirConditioning
    {
        private float _Temperature;

        public AirConditioning(float temperature)
        {
            this.Temperature = temperature;
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
            if (e.NewTemperature > Temperature)
            {
                Console.WriteLine("Klimatyzacja pracuje");
            }
            else
            {
                Console.WriteLine("Klimatyzacja wyłączona");
            }
        }
    }
}
