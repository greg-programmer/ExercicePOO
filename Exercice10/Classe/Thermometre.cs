using Exercice10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10
{
    internal class Thermometre
    {
        private double _TemperatureKelvin;
         public double TemperatureKelvin
        { 
            get => _TemperatureKelvin;
            set
            {
                _TemperatureKelvin = 273.15;  
                _TemperatureKelvin = value += _TemperatureKelvin;

            }
       }   
        UniteTemperature UniteTemperature { get; set; }

        public Thermometre(double temperatureKelvin, UniteTemperature uniteTemperature)
        {
            TemperatureKelvin = temperatureKelvin;           
        }
        public double ConversionDegreKelvinToCelcius()
        {
            _TemperatureKelvin -= 273.15;
            return _TemperatureKelvin;
        }
        public double ConversionDegreCelciusToKelvin()
        {
            _TemperatureKelvin += 273.15;
            return _TemperatureKelvin;
        }
        public double ConversionDegreFahrenheitToKelvin()
        {
            _TemperatureKelvin += 457.87;
            return TemperatureKelvin;
        }
        public double ConversionDegreKelvinToFahrenheit()
        {
            _TemperatureKelvin -= 457.87;
            return TemperatureKelvin;
        }
        public override string ToString()
        {
            return $"Affichage de la température {_TemperatureKelvin}";
        }
    }
}
