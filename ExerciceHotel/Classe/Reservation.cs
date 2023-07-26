using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Reservation
    {
        private int Id { get; set; }
        private enum Statut { Prevu, enCours, Fini, Annule  }
        private List<Chambre> ChambreList { get; set;} = new List<Chambre>();
        private Client client { get; set; } 
    }
}
