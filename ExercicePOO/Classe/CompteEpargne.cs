using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public CompteEpargne(decimal solde) : base(solde) { }
          
        public decimal CreerUnDepotCompteEpargne(CompteEpargne compteEpargne, decimal depot)
        {
            decimal a = compteEpargne.Solde = depot += Solde;
            decimal epargne = a * 2 / 100;
            return Solde += epargne;
        }
        public decimal FaireUnRetraitCompteEpargne(CompteEpargne compteEpargne, decimal retrait)
        {
            return compteEpargne.Solde = Solde -= retrait;
        }
        public override string ToString()
        {
            return $"=== Compte épargne === \n" +
             $" Solde disponible : {Solde} Euros";
        }

    }
}
