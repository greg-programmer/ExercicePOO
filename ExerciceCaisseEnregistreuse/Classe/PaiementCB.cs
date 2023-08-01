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
        public override void Payer(Vente vente)
        {
            vente.TotalDesArticles();
            Console.WriteLine($"Montant par carte effectué le {DateTime} d'un montant de {vente.TotalDesArticles()}");
        }
    }
}
