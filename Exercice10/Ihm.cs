using Exercice10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10
{
    internal class Ihm
    {
        public void AfficherResultat()
        {
            UniteTemperature fahrenheit = UniteTemperature.Fahrenheit;
            string a = fahrenheit.ToString();
            UniteTemperature celsius  = UniteTemperature.Celsius;
            string b = celsius.ToString();
            UniteTemperature kelvin = UniteTemperature.Kelvin;
            string c = kelvin.ToString();            
            Thermometre thermometreA = new Thermometre(10, fahrenheit);
            Console.WriteLine($"{thermometreA.ConversionDegreKelvinToFahrenheit()} {a}");
            Console.WriteLine($"{thermometreA.ConversionDegreFahrenheitToKelvin()} {c}");
            Console.WriteLine($"{thermometreA.ConversionDegreKelvinToCelcius()} {b}");
            Console.WriteLine($"{thermometreA.ConversionDegreCelciusToKelvin()} {c}");                    
        }
      
    }
    
}
