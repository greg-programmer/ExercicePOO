using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCaisseEnregistreuse.Classe
{
    internal class Paiement
    {
        public int IdentifiantDeReference { get; set; }

        public Paiement(int identifiantDeReference)
        {
            IdentifiantDeReference = identifiantDeReference;
        }

        public virtual void Payer() { }
    } 
}
