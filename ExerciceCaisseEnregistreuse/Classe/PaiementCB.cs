using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class PaiementCB : Paiement
    {
        public PaiementCB(int identifiantDeReference) : base(identifiantDeReference)
        {
        }
        public override void Payer(Vente vente,double totalPaiement)
        {
            Console.WriteLine($"Paiement effectué en carte le {DateTime.Now.ToString().Substring(0, 10)} d'un montant de {totalPaiement} £uros");
        }
    }
}
