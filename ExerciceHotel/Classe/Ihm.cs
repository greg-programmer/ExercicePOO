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
        List<Chambre> listeChambres = new List<Chambre>();
        List<Reservation> reservations = new List<Reservation>();
        List<Client> clients = new List<Client>();
        Client client;
        public void IHM()
        {
            Console.Write("Quel est le nom de l'Hotel ?");
            string nameHotel = Console.ReadLine(); 
            Console.WriteLine($"{nameHotel} créé avec succès !");
            Hotel hotel = new Hotel(nameHotel);
            AfficherMenuPrincipal();
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

            ChoisirNumeroDuMenu();
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
        public void AfficherMenuPrincipal()
        {
            Console.WriteLine("=== Menu Principal ===\n");
            Console.WriteLine("1. Ajouter un client");
            Console.WriteLine("2. Afficher la liste des clients");
            Console.WriteLine("3. Afficher les réservations d'un client");
            Console.WriteLine("4. Ajouter une réservation");
            Console.WriteLine("5. Annuler une réservation");
            Console.WriteLine("6. Afficher la liste des réservations");
            Console.WriteLine("0. Quitter");
        }
        public void ChoisirNumeroDuMenu()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("=== Ajout d'un client ===\n");
                        Console.WriteLine("Quel est le nom du client ? ");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Quel est le prénom du client ? ");
                        string prenom = Console.ReadLine();
                        Console.WriteLine("Quel est le numéro du client ? ");
                        string tel = Console.ReadLine();
                        client = new Client(nom, prenom, tel);
                        clients.Add(client);
                        Console.WriteLine($"{client.GetType().Name} ajouté avec succès !");
                        break;
                    case "2":
                        AfficherLalisteDesClients();
                        break;
                    case "3":
                        AfficherLalisteDesReservationsDesClient();
                        break;
                    case "4":
                        if(client == null)
                        {
                            Console.WriteLine("Pour réserver, il faut s'inscrire !");
                            break;
                        }
                        client.FaireUneReservation(client,listeChambres,reservations);
                        Console.WriteLine($" La réservation a été ajouté avec succès !");
                        break;
                        case "5":
                        if (client == null)
                        {
                            Console.WriteLine("Pour annuler une réservation, il faut s'inscrire !");
                            break;
                        } else if (reservations.FirstOrDefault(reservation => reservation.Id == client.Id) == null)
                        {
                            Console.WriteLine($"Aucune réservation du nom de {client.FirstName} {client.LastName}");
                            break;
                        }    
                        client.AnnulerUneReservation(client,listeChambres,reservations);
                        Console.WriteLine($" La réservation a été annulé avec succès !");
                        break; 
                    case "6":
                        AfficherLalisteDesReservationsDesClient();
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
            } while (input != "0");           
        }

    }
}
