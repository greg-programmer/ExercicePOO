using Exercice09.Enums;

namespace Exercice09.Classes
{
    internal abstract class CompteBanquaire
    {
        protected decimal Solde { get; set; }      
        private List<CompteBanquaire> compteBanquaires { get; set; } = new List<CompteBanquaire>();
        private static List<string> listeDesOperations { get; set; } = new List<string>() { };

  
        public CompteBanquaire(decimal solde)
        {
           Solde = solde;            
        }
        public void StockerDepotEtSolde(decimal montantSaisie)
        {
            Operation montant = new Operation(montantSaisie);
            string a = $"{montant.AfficherDepot()} +{montantSaisie} Le reste du solde est de {Solde}";
            listeDesOperations.Add(a);
        }
        public void StockerRetraitEtSolde(decimal montantSaisie)
        {
            Operation montant = new Operation(montantSaisie);
            string a = $"{montant.AfficherRetrait()} -{montantSaisie} Le reste du solde est de {Solde}";
            listeDesOperations.Add(a);
        }
        public virtual string ChoisirUnDepot()
        {
            OperationEnum operationEnum = OperationEnum.Depot;
            return operationEnum.ToString();
        }
        public virtual string ChoisirUnRetrait()
        {
            OperationEnum operationEnum = OperationEnum.Retrait;
            return operationEnum.ToString();
        }
        public void ListerLesComptesBanquaires()
        {
            foreach (var item in compteBanquaires)
            {
                Console.WriteLine(item);
            }
        }
        public void AfficherLalisteDesOperations()
        {
            foreach (var item in listeDesOperations)
            {
                Console.WriteLine(item);    
            }
        }
        public bool ControleSolde(CompteBanquaire compteBanquaire)
        {
            if(compteBanquaire.Solde < 0)
            {
                return false;
            }
            return true;
        }
    }
}
