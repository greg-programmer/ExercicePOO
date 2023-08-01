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
        List<Produit> Panier { get; set;}  
        Evente Evente { get; set; } 
        public void AjouterUnproduitAuPanier(Produit produit)
        {
            Evente = Evente.EnCours;
            Panier.Add(produit);
        }
    }
}
