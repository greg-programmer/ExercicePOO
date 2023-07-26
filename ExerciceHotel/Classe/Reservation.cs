using ExerciceHotel.Enum;
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
         EReservation EReservation { get; set; }
        private List<Chambre> ChambreList { get; set;} = new List<Chambre>();
        private Client Client { get; set; }

        public Reservation(int id, List<Chambre> chambreList, Client client, EReservation enumReservation)
        {
            Id = id;
            ChambreList = chambreList;
            Client = client;
            EReservation = enumReservation;
        }
    }
}
