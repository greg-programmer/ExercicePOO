using ExerciceHotel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Chambre
    {
        public int Numero { get; set; }
        public EChambre EChambre { get; set; }
        public int NbrChambres { get; set; }
        public decimal Tarif { get; set; }    

        public Chambre(int numero, EChambre eChambre,int nbrChambres, decimal tarif)
        {
            Numero = numero;
            EChambre = eChambre;
            NbrChambres = nbrChambres;
            Tarif = tarif;          
        }
    }
}
