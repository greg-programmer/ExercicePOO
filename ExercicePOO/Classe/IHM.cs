using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class IHM  
    {
       
           
        public void Start()
        {
            SaisiePourInscriptionUtilisateur();
        }
        public void SaisiePourInscriptionUtilisateur() 
        {
            //List<CompteBanquaire> listComptBanquaire = new List<CompteBanquaire>();            
            List<Client> listClient = new List<Client>();           
            Console.Write("Veuillez entrer votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez entrer votre prenom : ");
            string prenom = Console.ReadLine();
            Console.Write("Veuillez entrer votre numéro de téléphone : ");
            string telephone = Console.ReadLine();
            Console.Write("Veuillez entrer votre identifiant : ");
            int identifiant = int.Parse(Console.ReadLine());
            Client client = new Client(nom, prenom,telephone);            
            CompteCourant compteCourant = new CompteCourant(0);
            CompteEpargne compteEpargne = new CompteEpargne(0);
            ComptePayant comptePayant = new ComptePayant(0);
            string input = "";
            do
            {               
                Console.Clear();
                Console.WriteLine(" ===Menu Principal ===\n");
                Console.WriteLine("1. lister les comptes banquaires");
                Console.WriteLine("2. Creer un compte banquaire");
                Console.WriteLine("3. Effectuer un dépôt");
                Console.WriteLine("4. Effectuer un retrait");
                Console.WriteLine("5. Afficher les opérations et le solde");
                Console.WriteLine("0 Annuler la création de compte");
                Console.Write("Votre choix : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("=== Affichages des comptes banquaires\n");
                        client.AfficherLalisteDesComptesBanquaires();
                        Console.Write("Appuyez sur une touche pour revenir...");
                        input = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" === Création de compte ===\n");
                        Console.WriteLine("1. Créer un compte courant");
                        Console.WriteLine("2. Creer un compte épargne (Taux 2%)");
                        Console.WriteLine("3. Créer un compte payant (5 Euros)");                       
                        Console.WriteLine("0 Annuler la création de compte");
                        Console.Write("Votre choix : ");
                        input = Console.ReadLine();
                        switch (input)
                        {    
                    case "1":
                                listClient.Add(client);
                                compteCourant = new CompteCourant(0);
                                client.CreerUnCompteCourant(compteCourant, client);                             
                                Console.WriteLine(" === Votre compte courante a été créé ! ===\n");
                                Console.Write("Appuyez sur une touche pour revenir...");
                                input = Console.ReadLine();
                                ;
                        break;
                    case "2":
                                listClient.Add(client);
                                Console.WriteLine(" === Votre compte épargne a été créé ! ===\n");
                                compteEpargne = new CompteEpargne( 0);
                                client.CreerUnCompteEpargne(compteEpargne, client);
                                Console.Write("Appuyez sur une touche pour revenir...");
                                input = Console.ReadLine();
                                ;
                        break;
                    case "3":
                                listClient.Add(client);
                                bool controlerSolde = comptePayant.ControleSolde(comptePayant);                               
                                comptePayant = new ComptePayant(0);                                
                                client.CreerUnComptePayant(comptePayant, client);
                                if (controlerSolde) break;
                                Console.WriteLine(" === Votre compte payant a été créé ! ===\n");
                                Console.Write("Appuyez sur une touche pour revenir...");
                                input = Console.ReadLine();
                                break;
                            case "0":
                                break;
                    default:
                        break;
                        }
                        ;
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Quel type de compte souhaitez vous créditer ?");
                        Console.WriteLine("1. compte courant");
                        Console.WriteLine("2. compte épargne");
                        Console.WriteLine("3. compte payant");
                        Console.Write("Appuyez sur une touche pour revenir...");
                        Console.Write("Votre choix : ");
                        input = Console.ReadLine();
                        if(input == "1")
                        {
                            Console.Write("Veuillez choisir le montant à créditer : ");
                            decimal montantACrediter = decimal.Parse(Console.ReadLine());
                            compteCourant.CreerUnDepotCompteCourant(compteCourant,montantACrediter);
                            compteCourant.StockerDepotEtSolde(montantACrediter);
                           
                        }
                        else if (input == "2")
                        {
                            Console.Write("Veuillez choisir le montant à créditer : ");                  
                            decimal montantACrediter = decimal.Parse(Console.ReadLine());
                            compteEpargne.CreerUnDepotCompteEpargne(compteEpargne, montantACrediter);
                            compteEpargne.StockerDepotEtSolde(montantACrediter);                          
                        }
                        else if(input == "3")
                        {
                            Console.Write("Veuillez choisir le montant à créditer : ");
                            decimal montantACrediter = decimal.Parse(Console.ReadLine());
                            comptePayant.CreerUnDepotComptePayant(comptePayant, montantACrediter);
                            compteEpargne.StockerDepotEtSolde(montantACrediter );
                        }                       
                        ;
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Quel type de compte souhaitez vous débiter ?");
                        Console.WriteLine("1. compte courant");
                        Console.WriteLine("2. compte épargne");
                        Console.WriteLine("3. compte payant");
                        Console.Write("Appuyez sur une touche pour revenir...");
                        Console.Write("Votre choix : ");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.Write("Veuillez choisir le montant à débiter : ");
                            decimal montantADebiter = decimal.Parse(Console.ReadLine());
                            compteCourant.FaireUnRetraitCompteCourant(compteCourant, montantADebiter);
                            compteCourant.StockerRetraitEtSolde(montantADebiter);

                        }
                        else if (input == "2")
                        {
                            Console.Write("Veuillez choisir le montant à déditer : ");
                            decimal montantADebiter = decimal.Parse(Console.ReadLine());
                            compteEpargne.FaireUnRetraitCompteEpargne(compteEpargne, montantADebiter);
                            compteEpargne.StockerRetraitEtSolde(montantADebiter);
                        }
                        else if (input == "3")
                        {
                            Console.Write("Veuillez choisir le montant à déditer : ");
                            decimal montantADebiter = decimal.Parse(Console.ReadLine());
                            comptePayant.FaireUnRetraitComptePayant(comptePayant, montantADebiter);
                            comptePayant.StockerRetraitEtSolde(montantADebiter);
                        }
                        ;                        
                        break;
                    case "5":
                        compteCourant.AfficherLalisteDesOperations();
                        Console.Write("Appuyez sur une touche pour revenir...");
                        Console.ReadLine();
                        //AfficherSoldeEtOpération//

                        break;
                    case "0":                      
                        ;
                        break;
                    default:
                        Console.WriteLine("Erreur de saisie!");
                        break;
                }         
            } while(input  != "0");
          
        }        
        
    }      
}
