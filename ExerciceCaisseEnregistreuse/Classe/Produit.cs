using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Produit
    {
        public static int Id { get; set; } = +1;
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }

        public Produit(string nom, double prix, int stock)
        {
            Nom = nom;
            Prix = prix;
            Stock = stock;
        }
        public override string ToString()
        {
            return $" || Nom de l'article : {Nom} || Prix unitaire : {Prix} Euros || Quantité Disponible : {Stock} ||";
        }
    }
}
