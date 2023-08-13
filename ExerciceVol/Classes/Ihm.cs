using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Classes
{
    internal class Ihm
    {
        public void IHM()
        {        
            Vols vols = new Vols();
            vols.Affiche();
            Console.WriteLine();
            vols.Appartient();
            Console.WriteLine(vols.Liste_Successeurs("Paris"));
        }     
    }
}
