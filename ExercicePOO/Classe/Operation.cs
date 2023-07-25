using Exercice09.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice09.Classes
{
    internal class Operation
    {
        private decimal Montant { get; set; }

        public Operation(decimal montant)
        {
            Montant = montant;
        }

        private OperationEnum Statut { get;}

        public OperationEnum AfficherRetrait()
        {
            OperationEnum retrait = OperationEnum.Retrait;   
            return retrait;
        }
        public OperationEnum AfficherDepot()
        {
            OperationEnum depot = OperationEnum.Depot;             
            return depot;
        }
    }
}
