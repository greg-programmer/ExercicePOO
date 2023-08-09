using ExerciceVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Classes
{
    internal class Vols : IVol
    {
        List<VolDirect> Vol { get; set; } = new List<VolDirect>();
        List<string> VolNamesArrived { get; set; } = new List<string>();

        public List<string> Liste_Successeurs(string villeDepart)
        {
            foreach (var volDirect in Vol)
            {
                VolNamesArrived.Add(volDirect.Start);
            }
            return VolNamesArrived;
        }
        public void Affiche()
        {
            foreach (var volDirect in Vol)
            {
                Console.WriteLine(volDirect);
            }
        }

        public bool Appartient()
        {
            throw new NotImplementedException();
        }
   
    }
}
