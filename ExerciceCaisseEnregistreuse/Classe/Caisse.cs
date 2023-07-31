using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Caisse
    {
        Dictionary<string, Produit> Produits = new Dictionary<string, Produit>();
        Dictionary<string, Vente> Ventes = new Dictionary<string, Vente>();

        public Caisse(Dictionary<string, Produit> produits, Dictionary<string, Vente> ventes)
        {
            Produits = produits;
            Ventes = ventes;
        }
    }
}
