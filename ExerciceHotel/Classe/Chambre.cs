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
        private int Numero { get; set; }
        EChambre EChambre { get; set; }
        private int NbrLits{ get; set; } 
        private decimal Tarif { get; set; }

        public Chambre(int numero, EChambre eChambre, int nbrLits, decimal tarif)
        {
            Numero = numero;
            EChambre = eChambre;
            NbrLits = nbrLits;
            Tarif = tarif;
        }
    }
}
