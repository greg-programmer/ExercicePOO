using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class CompteCourant : CompteBanquaire
    {

        public CompteCourant(decimal solde) : base(solde) { }     
        public CompteCourant CreerUncompteCourant(decimal solde)
        {
            CompteCourant compteCourant = new CompteCourant(solde);
            return compteCourant;
        }
        public decimal CreerUnDepotCompteCourant(CompteCourant compteCourant, decimal depot)
        {
            return compteCourant.Solde = depot += Solde;
        }
        public decimal FaireUnRetraitCompteCourant(CompteCourant compteCourant, decimal retrait)
        {
            return compteCourant.Solde = Solde -= retrait;
        }
        public override string ToString()
        {
            return $"=== Compte courant === \n" +
                $" Solde disponible : {Solde} Euros";
                
        }

    }
}
