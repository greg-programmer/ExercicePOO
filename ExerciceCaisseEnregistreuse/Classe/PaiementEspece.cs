using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class PaiementEspece : Paiement
    {
        public PaiementEspece(int identifiantDeReference) : base(identifiantDeReference)
        {
        }
        public override void Payer()
        {
            base.Payer();
        }
    }
}
