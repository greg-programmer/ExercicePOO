using ExerciceForum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal class Abonne : Utilisateur, IAbonne
    {
        public Abonne(string prenom, string nom, int age) : base(prenom, nom, age)
        {
        }

        public void AjouterUneNouvelle(Nouvelle nouvelle)
        {
            Forum.Nouvelles.Add(nouvelle);            
        }
        public void ConsulterNouvelle()
        {
            foreach (var nouvelles in Forum.Nouvelles)
            {
                Console.WriteLine(nouvelles);
            }
        }
        public override string ToString()
        {
            return $"Nom : {Nom} Prénom : {Prenom} Age : {Age}";
        }
    }
}
