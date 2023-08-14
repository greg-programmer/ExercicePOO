using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal abstract class Utilisateur
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }

        protected Utilisateur(string prenom, string nom, int age)
        {
            Prenom = prenom;
            Nom = nom;
            Age = age;
        }
    }
}
