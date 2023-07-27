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

        public int Id { get; set; }   
        public List<Chambre> ChambreList { get; set;} = new List<Chambre>();
        public Client Client { get; set; }
        public EReservation EReservation { get; set; }

        public Reservation(int id, List<Chambre> chambreList, Client client,EReservation eReservation)

        {
            Id = id;
            ChambreList = chambreList;
            Client = client;
            EReservation = eReservation;          

        }
        public override string ToString()
        {
            return $"{Client.FirstName} {Client.LastName} reservé : Chambre n°{Id} ";
        }
    }
}
