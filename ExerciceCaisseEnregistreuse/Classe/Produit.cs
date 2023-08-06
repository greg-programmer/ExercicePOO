using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Produit
    {
        private static int AutoIncrementId { get; set; }   
        public int Id { get;}
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }  

        public Produit(string nom, double prix, int stock)
        {
            Nom = nom;
            Prix = prix;
            Stock = stock;
            AutoIncrementId = AutoIncrementId +1;
            Id = AutoIncrementId;
        }
        
        public override string ToString()
        {
            return $" || Nom de l'article : {Nom} || Prix unitaire : {Prix} Euros || Quantité Disponible : {Stock} ||";
        }
    }
}
