using ExerciceForum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal class Moderateur : Utilisateur, IModerateur
    {
        public Moderateur(string prenom, string nom, int age) : base(prenom, nom, age)
        {
        }

        public void AjouterUnAbonne(Abonne abonne)
        {
            Forum.Abonnes.Add(abonne);
        }

        public void BannirUnAbonne(string Nom, string prenom)
        {
            var a = Forum.Abonnes.FirstOrDefault(a => a.Nom == Nom && a.Prenom == prenom);
            if (a != null) 
            {
             Forum.Abonnes.Remove(a);
            }
        }

        public void ConsulterNouvelles()
        {
            foreach (var nouvelle in Forum.Nouvelles)
            {
                Console.WriteLine(nouvelle);
            }
        }

        public void ListerAbonnes()
        {
            foreach (var abonne in Forum.Abonnes)
            {
                Console.WriteLine(abonne);
            }
        }

        //Le modérateur peut supprimer une nouvelle, bannir un
        //abonné, ajouter un abonné ou lister les abonnées et les
        //nouvelles//
        public void SupprimerUneNouvelle(string nouvelleASupprime)
        {
            var a = Forum.Nouvelles.FirstOrDefault(e => e.Sujet == nouvelleASupprime);
            if (a != null)
            {
                Forum.Nouvelles.Remove(a);
            }
        }
    }
}
