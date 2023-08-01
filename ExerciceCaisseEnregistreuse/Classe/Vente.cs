using ExerciceCaisseEnregistreuse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Vente
    {
        public int Id { get; set; }
        public List<Produit> Panier { get; set;} = new List<Produit>();     
        Evente Evente { get; set; }
         

        public void AjouterUnproduitAuPanier(KeyValuePair<string, Produit> premierProduit)
        {
            Evente = Evente.EnCours;
            Panier.Add(premierProduit.Value);
        }
        public void AfficherLesVentes()
        {
            double sum = 0;
            Console.WriteLine(" === Articles dans le panier === ");
            foreach (var item in Panier)
            {
                Console.WriteLine($"Quantité : {item.QuantiteProduitAvantValidationDuPanier} | nom de l'article  {item.Nom} | prix unitaire : {item.Prix} Euros | prix total de l'article : {item.QuantiteProduitAvantValidationDuPanier* item.Prix} £uros");
                sum += (item.QuantiteProduitAvantValidationDuPanier * item.Prix);
            }
            Console.WriteLine($"Le prix total des articles est de : {sum} £uros");
        }
        public double TotalDesArticles()
        {
            double sum = 0;
            foreach (var item in Panier)
            {
              sum += (item.QuantiteProduitAvantValidationDuPanier * item.Prix);
            }
            return sum;
        }
      
    }
}
