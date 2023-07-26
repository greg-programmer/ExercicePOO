using Exercice10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            UniteTemperature = uniteTemperature;
        }

        public string Conversion()
        {
            double result;
            string stringResul = "";
            if(UniteTemperature == UniteTemperature.Fahrenheit)
            {
                result = _TemperatureKelvin -= 457.87;
                stringResul = $"{result}  {UniteTemperature}  ";
            }
            else if(UniteTemperature == UniteTemperature.Celsius)
            {
                result = _TemperatureKelvin -= 273.15;
                stringResul = $"{result} {UniteTemperature} ";
            }
            else if(UniteTemperature == UniteTemperature.Kelvin)
            {              
                stringResul = $"{_TemperatureKelvin}  {UniteTemperature} ";
            }
            return stringResul;
        }      
      
    }
}


