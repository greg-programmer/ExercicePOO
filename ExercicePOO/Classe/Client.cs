using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class Client
    {
        private string Nom { get; set; }  
        private string Prenom { get; set; }     
        private string Telephone { get; set; }
      
        private List<Client> listClients = new List<Client> { };
        private List<CompteBancaire> listCompteBanquaires = new List<CompteBancaire>();
        public Client(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;        
            Telephone = telephone;
        }
        public Client CreerUnClient(Client client)
        {            
            
            listClients.Add(client);
            return client;
        }
        public Client CreerUnCompteCourant(CompteCourant compteCourant, Client client)
        {
            client.listCompteBanquaires.Add(compteCourant);
            return client;
        }
        public Client CreerUnCompteEpargne(CompteEpargne compteEpargne, Client client)
        {
            client.listCompteBanquaires.Add(compteEpargne);
            return client;
        }
        public Client CreerUnComptePayant(ComptePayant comptePayant, Client client)
        {           
            comptePayant.AjouterTarifSurComptePayant(comptePayant);
           bool controlerSolde =  comptePayant.ControleSolde(comptePayant);
            if(controlerSolde) 
            {
                client.listCompteBanquaires.Add(comptePayant);
                return client;
            }
            Console.WriteLine("Desolé mais vous n'avez pas assez de solde !");
            Console.Write("Appuyez sur une touche pour revenir...");
            Console.ReadLine();
           return client;   
        }  
        public void AfficherLalisteDesComptesBanquaires()
        {
            foreach (CompteBancaire compteBanquaire in listCompteBanquaires)
            {
                Console.WriteLine($"{compteBanquaire}\n" +
                $" Nom : {Nom} \n" +
                $" prénom : {Prenom}\n" +
                $"N° {Telephone}");
                              
            }
        }
        public override string? ToString()
        {
            return $" Nom : {Nom} " +
                $"prénom{Prenom}";            
        }       
    }
}
