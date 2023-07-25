using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceScientifique.Classe
{
    internal class Scientifique : Travailleur
    {
        private string _Discipline { get; set; }
        private string TypeScientifique { get; set; }
        public Scientifique(string nom, string prenom, string telephone,
            string email, string nomEntreprise, string adresseEntreprise,
            string telephonePro, string discipline, string typeScientifique)
            : base(nom, prenom, telephone, email, nomEntreprise, adresseEntreprise, telephonePro)
        {
            _Discipline = discipline;
            TypeScientifique = typeScientifique;
        }
        public override string ToString()
        {
            return $"Discipline du scientifique : {_Discipline}\n" +
                $"Type du scientifique : {TypeScientifique}";
        }
    }
}
