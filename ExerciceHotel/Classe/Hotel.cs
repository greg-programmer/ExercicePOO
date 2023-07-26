using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Hotel
    {
        private List<Client> clients = new List<Client>();
        private List<Chambre> chambres = new List<Chambre>();
        private Client Client { get; set; } 
    }
}
