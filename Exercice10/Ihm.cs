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
            UniteTemperature celsius  = UniteTemperature.Celsius;         
            UniteTemperature kelvin = UniteTemperature.Kelvin;              
            Thermometre thermometreA = new Thermometre(1, celsius);
            Console.WriteLine(thermometreA.Conversion());
            Thermometre thermometreB = new Thermometre(1, fahrenheit);
            Console.WriteLine(thermometreB.Conversion());
            Thermometre thermometreC = new Thermometre(1, kelvin);
            Console.WriteLine(thermometreC.Conversion());
        }
      
    }
    
}
