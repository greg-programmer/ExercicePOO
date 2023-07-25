using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceScientifique.Classe
{
    internal abstract class Personne
    {
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected string _telephone;
        protected string Telephone
        {
            get { return _telephone; }
            set
            {
                if (value.Length == 10)
                {
                    _telephone = value;
                }
            }
        }
        public string Email { get; set; }

        public Personne(string nom, string prenom, string telephone, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Email = email;
        }
    }
}
