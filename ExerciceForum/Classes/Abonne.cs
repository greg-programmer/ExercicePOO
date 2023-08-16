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
        public void RepondreAUneNouvelle(string reponse,string sujet)
        {
           var a  = Forum.Nouvelles.FirstOrDefault(a => a.Sujet == sujet);
            if(a != null)
            {
                a.Reponse = reponse;
            }          
        }
        public void ConsulterNouvelles()
        {
            foreach (var nouvelles in Forum.Nouvelles)
            {
                Console.WriteLine(nouvelles);
            }
        }
        public void ConsulterUneNouvelle(string sujetRechercher)
        {
            var a = Forum.Nouvelles.FirstOrDefault(a => a.Sujet == sujetRechercher);
            Console.WriteLine(a);
        }
        public override string ToString()
        {
            return $"Nom : {Nom} Prénom : {Prenom} Age : {Age}";
        }
    }
}
