using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Chambre
    {
        private int Numero { get; set; }
        private enum Type { Libre,Occuper,Nettoyer}
        private string[] NbrChambres { get; set; } = new string[20];
        private decimal Tarif { get; set; }

    }
}
