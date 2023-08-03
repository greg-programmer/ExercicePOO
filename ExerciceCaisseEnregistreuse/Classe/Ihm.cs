using ExerciceCaisseEnregistreuse.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Ihm
    {
        Evente Evente { get; set; }
        private Dictionary<string, Produit> Produits = new Dictionary<string, Produit>();
        private Dictionary<string, Vente> Ventes = new Dictionary<string, Vente>();    
        private List<int> QuantiteAvantValidation = new List<int>();
        private Vente Vente { get; set; } = new Vente();    
        public void IHM()        {
            
            //Initialisation du magasin
         
            Caisse caisse = new Caisse(Produits,Ventes);
            Produits.Add("01POM",new Produit("Pomme", 2.50, 8));
            Produits.Add("01BAN", new Produit("Banane", 2.50, 5));
            Produits.Add("01RAS", new Produit("Raisin", 2.50, 8));
            Produits.Add("01POI", new Produit("Poire", 2.50, 10));
            Produits.Add("01PAS", new Produit("Pasteque", 2.50, 10));
            Produits.Add("01SAL", new Produit("Salade", 2.50, 12));
            Produits.Add("01MEL", new Produit("Melon", 2.50, 11));
            Produits.Add("01FRA", new Produit("Fraise", 2.50, 3));
            Produits.Add("01CER", new Produit("Cerise", 2.50, 9));
            //Création d'un produit//
            AfficherMenuPrincipal();
        }
        public void AfficherMenuPrincipal()
        {
            string input = "";
            Vente vente = new Vente();
            do
            {
                Console.WriteLine(" === Menu Principal ===\n");
                Console.WriteLine("1. Voir les produits");
                Console.WriteLine("2. Ajouter un produit dans la caisse");
                Console.WriteLine("3. Faire une vente");
                Console.WriteLine("0. Quitter");
                Console.Write("Votre choix : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AffichertousLesProduits();
                        break;
                    case "2":
                        AjouterUnProduitDansLaCaisse();
                        break;
                    case "3":
                        AffichertousLesProduits();
                        do
                        {
                            string choix = "";
                            Console.Clear();
                            Console.WriteLine(" === Stock Disponible === ");
                            AffichertousLesProduits();
                            Console.WriteLine(" === Ajouter un article dans le panier === \n");
                            Console.Write("Quel article souhaitez vous ajouter à votre panier (Entrez le code de l'article) ? ");
                            //Faire Une méthode pour mettre à jour le stock//                    ;
                            string nomDuProduit = Console.ReadLine().ToUpper();
                          //Gérer une condition en cas d'erreur de saisie
                            var premierProduit = Produits.FirstOrDefault(produit => produit.Key.ToUpper() == nomDuProduit);
                            Console.Write($"Combien d'article {premierProduit.Value.Nom} souhaitez vous ajouter dans le panier ?");
                            int.TryParse(Console.ReadLine().ToUpper(), out int quantiteChoisie);
                            if(premierProduit.Value.Stock - quantiteChoisie >= 0)
                            {
                               for(int i = 0;i < Vente.Panier.Count; i++)
                                {
                                    if (Vente.Panier[i].Nom == premierProduit.Value.Nom)
                                    {
                                        QuantiteAvantValidation[i] = QuantiteAvantValidation[i] + quantiteChoisie;
                                        break;
                                    }
                                }                                    
                                if(Vente.Panier.FirstOrDefault(vente => vente.Nom == premierProduit.Value.Nom) == null)
                                {
                                    Vente.Panier.Add(premierProduit.Value);
                                    QuantiteAvantValidation.Add(quantiteChoisie);
                                }                              
                                Console.WriteLine("Votre article a été ajouté avec succès!");
                                Console.WriteLine("1.Continuer la vente");
                                Console.WriteLine("2.Valider la vente");
                                Console.WriteLine("3.Annuler la vente");
                                Console.Write("Faites votre choix : ");
                                choix = Console.ReadLine();
                            }
                            else
                            {
                               Console.WriteLine("La quantité n'est plus en stock !");
                                Console.WriteLine("Appuyez sur une touche pour revenir à la vente...");
                                Console.ReadLine();
                            }                        
                            
                            switch (choix)
                            {
                                case "1":
                                    Evente = Evente.EnCours;
                                    break;
                                case "2":
                                    Evente = Evente.Validée;
                                    Console.WriteLine("Choisissez votre moyen de paiement : ");
                                    Console.WriteLine("1.Carte");
                                    Console.WriteLine("2.Espèce");
                                    string choixPaiement = Console.ReadLine();
                                    if(choixPaiement == "1")
                                    {
                                        double totalUnitaire = 0;
                                        double totalPaiement = 0;
                                        for (var i = 0; i < Vente.Panier.Count; i++)
                                        {
                                            Vente.Panier[i].Stock = Vente.Panier[i].Stock - QuantiteAvantValidation[i];
                                            totalUnitaire = QuantiteAvantValidation[i] * Vente.Panier[i].Prix;
                                            totalPaiement += totalUnitaire;
                                        }                                      
                                        PaiementCB paiementCB = new PaiementCB(1222223);                                        
                                        paiementCB.Payer(vente,totalPaiement);
                                        Console.WriteLine(paiementCB);
                                        Console.ReadLine();
                                    }else if(choixPaiement == "2")
                                    {
                                        double totalUnitaire = 0;
                                        double totalPaiement = 0;
                                        for (var i = 0; i < Vente.Panier.Count; i++)
                                        {
                                            Vente.Panier[i].Stock = Vente.Panier[i].Stock - QuantiteAvantValidation[i];
                                            totalUnitaire = QuantiteAvantValidation[i] * Vente.Panier[i].Prix;
                                            totalPaiement += totalUnitaire;
                                        }
                                        PaiementEspece paiementEspece = new PaiementEspece(1222224);
                                        paiementEspece.Payer(vente,totalPaiement);
                                        Console.WriteLine(paiementEspece);
                                        Console.ReadLine();
                                    }
                                 
                                    //Mise en place d'une méthode pour valider le paiement//
                                    break;
                                    case "3":
                                    Evente = Evente.Annulée;
                                    //Mise en place d'une méthode pour annuler le paiement//
                                    break;
                                    default:
                                    break;
                            }
                        } while (Evente == Evente.EnCours);                         
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
            } while(input != "0");           
        }
        public void RechercherUnProduit()
        {
            string nomDuProduit = Console.ReadLine().ToLower();
            foreach (var item in Produits)
            {
                if (item.Key.ToLower().Contains(nomDuProduit))
                {
                    Console.WriteLine($"Le nom : {item.Value.Nom} ,Le prix : {item.Value.Prix} Le stock : {item.Value.Stock}");
                }
            }          
        }
        public void AffichertousLesProduits()
        {
            foreach (var ProduitsEnStock in Produits)
            {
               Console.WriteLine($"Code article : {ProduitsEnStock.Key} {ProduitsEnStock.Value}");
            }
        }
        public void AjouterUnProduitDansLaCaisse()
        {
            Console.Write("Quel est le nom du produit ? ");
            string nomArticle = Console.ReadLine();
            Console.Write("Quel est le prix du produit ? ");
            double prixArticle = double.Parse(Console.ReadLine());
            Console.Write("Quel est le stock du produit ? ");
            int quantiteStock = int.Parse(Console.ReadLine());
            Produit produit = new Produit(nomArticle, prixArticle,quantiteStock);
            string codeArticle = produit.Nom.Substring(0,3).ToUpper();
            Produits.Add($"01{codeArticle}",produit);

        }
        public void AjouterUnProduitDansLePanier(Dictionary<string, Produit> ProduitsEnStock)
        {
            Console.WriteLine(" === Ajouter un article dans le panier === \n");
            Console.Write("Quel article souhaitez vous ajouter à votre panier (Entrez le code de l'article) ? ");
            string nomDuProduit = Console.ReadLine().ToUpper();
            do
            {
                var premierProduit = ProduitsEnStock.FirstOrDefault(produit => produit.Key.ToUpper() == nomDuProduit);
                if (premierProduit.Value != null)
                {
                    Console.Write($"Combien d'article {premierProduit.Value.Nom} souhaitez vous ajouter dans le panier ?");
                    int.TryParse(Console.ReadLine().ToUpper(), out int nombreDuStock);
                    premierProduit.Value.Stock = premierProduit.Value.Stock - nombreDuStock;
                    Console.WriteLine("1.Valider la vente");
                    Console.WriteLine("2.Ajouter un article");
                    Console.WriteLine("Appuyez sur une autre touche pour annuler la vente...");
                    nomDuProduit = Console.ReadLine();
                    //Creer la fonction pour changer le stock //
                }
                else
                {
                    Console.WriteLine("Le code article n'existe pas !");
                    Console.Write("Quel article souhaitez vous ajouter à votre panier (Entrez le code de l'article) ? ");
                    nomDuProduit = Console.ReadLine().ToUpper();
                }

            } while (nomDuProduit != "0" || Evente == Evente.Validée);       
            if(Evente == Evente.Validée)
            {

            }
            else
            {
                return;
            }
        }        
    }    
}
