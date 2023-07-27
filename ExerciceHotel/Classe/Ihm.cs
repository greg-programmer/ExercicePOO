using ExerciceHotel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Ihm 
    {
        EChambre EChambre { get; set; }
        List<Chambre> listeChambres = new List<Chambre>();
        List<Reservation> reservations = new List<Reservation>();
        List<Client> clients = new List<Client>();
        public void IHM()
        {
          
            Hotel hotel = new Hotel();
            // ======= Initilisation des chambres d'hotel =======//
            Chambre chambreA = new Chambre(1, EChambre.Libre, 2, 45);
            Chambre chambreB = new Chambre(2, EChambre.Libre, 3, 45);
            Chambre chambreC = new Chambre(3, EChambre.Libre, 1, 45);
            Chambre chambreD = new Chambre(4, EChambre.Libre, 2, 45);
            Chambre chambreE = new Chambre(5, EChambre.Libre, 2, 45);
            Chambre chambreF = new Chambre(6, EChambre.Libre, 2, 45);
            Chambre chambreG = new Chambre(7, EChambre.Libre, 3, 45);
            Chambre chambreH = new Chambre(8, EChambre.Libre, 2, 45);
            Chambre chambreI = new Chambre(9, EChambre.Libre, 2, 45);
            listeChambres.Add(chambreA);
            listeChambres.Add(chambreB);
            listeChambres.Add(chambreC);
            listeChambres.Add(chambreD);
            listeChambres.Add(chambreE);
            listeChambres.Add(chambreF);
            listeChambres.Add(chambreG);
            listeChambres.Add(chambreH);
            listeChambres.Add(chambreI);
            //==========================================================//
            Client clientA = new Client("Schoemaecker","Grégory","0606060606");          
            clients.Add(clientA);
            clientA.FaireUneReservation(clientA,listeChambres,reservations);            
            Client clientB = new Client( "Schoemaecker", "Aurélie", "0606060606");
            clients.Add(clientB);
            clientB.FaireUneReservation(clientB,listeChambres,reservations);
            clientB.FaireUneReservation(clientB, listeChambres, reservations);
            clientB.FaireUneReservation(clientB, listeChambres, reservations);
            clientB.FaireUneReservation(clientB, listeChambres, reservations);
            clientB.AnnulerUneReservation(clientB,listeChambres,reservations);
            AfficherLalisteDesClients();
            AfficherLalisteDesReservationsDesClient();
            AfficherLalisteDesReservationsDuClient(clientB);
            AfficherLalisteDesReservationsDuClient(clientA);
        }
        public void AfficherLalisteDesClients()
        {
            Console.WriteLine("===== Liste des clients =====");
            foreach (var listeDesCliens in clients)
            {
                Console.WriteLine(listeDesCliens);
            }
        }
        public void AfficherLalisteDesReservationsDesClient()
        {
            Console.WriteLine("===== Liste des reservations =====");
            foreach (var listeDesReservations in reservations)
            {
                Console.WriteLine(listeDesReservations);
            }
        }
        public void AfficherLalisteDesReservationsDuClient(Client client)
        {
            var reservationClient = reservations.Where(reservation => reservation.Client.FirstName == client.FirstName &&
            reservation.Client.LastName == client.LastName).ToList();
            Console.WriteLine($"===== Réservation du client {client.FirstName} {client.LastName}  =====");
            foreach (var item in reservationClient)
            {
                Console.WriteLine(item);
            }
        }

    }
}
