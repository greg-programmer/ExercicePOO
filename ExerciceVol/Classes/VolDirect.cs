using ExerciceVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Classes
{
    internal class VolDirect 
    {
        public string Start { get; set; }
        public string Arrived { get; set; }
        public string Day { get; set; }
        public DateTime DateTime { get; set; }

        public VolDirect(string start, string arrived, string day, DateTime dateTime)
        {
            Start = start;
            Arrived = arrived;
            Day = day;
            DateTime = dateTime;
        }
        public override string ToString()
        {
            return $" Ce vol part de {Start} vers {Arrived} le {Day} à{DateTime.Now.ToString().Substring(10,3)} heure";
        }     
    }
}
