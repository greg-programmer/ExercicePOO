using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Hotel
    {
        public List<Client> Clients = new List<Client>();
        private List<Chambre> chambres = new List<Chambre>();
        private List<Reservation> reservations = new List<Reservation>();   
        private Client Client { get; set; } 
        public void AjouterUnClient(Client client)
        {
            Clients.Add(client);    
        }
        public void AjouterUneReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        public void AjouterLaListeDesChambres(Chambre chambre)
        {
            chambres.Add(chambre);
        }
    }
}
