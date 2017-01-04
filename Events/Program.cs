using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(15f);
            AirConditioning airConditionig = new AirConditioning(25f);

            thermostat.TemperatureChanged += heater.TemperatureChanged;
            thermostat.TemperatureChanged += airConditionig.TemperatureChanged;

            thermostat.CurrentTemperature = 28f;

            Console.ReadKey();
        }
    }
}