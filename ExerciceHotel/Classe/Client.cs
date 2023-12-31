﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceHotel.Enum;

namespace ExerciceHotel.Classe
{
    internal class Client
    {
       public int Id { get; set; } = 0; //l'Id sera remplacé par le numéro de la chambre reservé//
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Phone { get; set; }   
        public Client(string lastName, string firstName, string phone)
        {        
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }
        public void FaireUneReservation(Client client, List<Chambre> chambres, List<Reservation> reservations)
        {
               EChambre chambreLibre = EChambre.Libre;
           var premiereChambreLibreTrouve = chambres.FirstOrDefault(chambres => chambres.EChambre == chambreLibre);
            client.Id = premiereChambreLibreTrouve.Numero;
            premiereChambreLibreTrouve.EChambre = EChambre.Occupe;
            Reservation reservation = new Reservation(client.Id, chambres, client, EReservation.Prevu);
            reservations.Add(reservation);
        }
        public void AnnulerUneReservation(Client client,List<Chambre> chambres, List<Reservation> reservations)
        {
            var ChambreOccupeEnLibre = chambres.FirstOrDefault(chambres => chambres.Numero == client.Id);         
            if(ChambreOccupeEnLibre == null)
            {
                Console.WriteLine($"Aucune réservation {client.FirstName} {client.LastName}");
                return;
            }
            ChambreOccupeEnLibre.EChambre = EChambre.Libre;
            var annulerReservation = reservations.FirstOrDefault(reservation => reservation.Client.Id == client.Id);
            reservations.RemoveAt(client.Id - 1);//Pour récupérer l'index de 0;
            client.Id = 0;
        }
        public override string ToString()
        {
            return $" ==============\n" +
                 $" Nom : {LastName}\n" +
                 $" Prénom : {FirstName}\n" +
                 $" Tél : {Phone}\n";
               
        }
    }
}
