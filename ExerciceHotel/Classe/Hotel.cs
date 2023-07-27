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
        public Client Client { get; set; } 
        public void AjouterUnClient(Client client)
        {
            Clients.Add(client);    
        } 
    }
}
