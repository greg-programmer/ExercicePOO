using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        public ComptePayant(decimal solde) : base(solde) { }
        public decimal AjouterTarifSurComptePayant(ComptePayant comptePayant)
        {
            return comptePayant.Solde = - 5;
        }
        public decimal CreerUnDepotComptePayant(ComptePayant comptePayant, decimal depot)
        {
            return comptePayant.Solde = depot += Solde;
        }
        public decimal FaireUnRetraitComptePayant(ComptePayant comptePayant, decimal retrait)
        {
            return comptePayant.Solde = Solde -= retrait;
        }
        public override string ToString()
        {
            return $"=== Compte payant === \n" +
              $" Solde disponible : {Solde} Euros";
        }

    }
}
