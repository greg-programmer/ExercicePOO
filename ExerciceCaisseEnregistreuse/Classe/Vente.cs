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
      
    }
}
