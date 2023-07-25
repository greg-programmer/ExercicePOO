

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceScientifique.Classe
{
    internal class Travailleur : Personne
    {
        private string NomEntreprise { get; set; }
        private string AdresseEntreprise { get; set; }
        private string TelephonePro { get; set; }
        public Travailleur(string nom, string prenom, string telephone, string email, string nomEntreprise, string adresseEntreprise, string telephonePro) : base(nom, prenom, telephone, email)
        {
            NomEntreprise = nomEntreprise;
            AdresseEntreprise = adresseEntreprise;
            TelephonePro = telephonePro;
        }
        public override string ToString()
        {
            return $"Nom de l'entreprise : {NomEntreprise}\n" +
                $"Adresse de l'entreprise : {AdresseEntreprise}\n" +
                $"Téléphone pro : {TelephonePro}\n" +
                $"Nom : {Nom}\n" +
                $"Prénom : {Prenom}\n" +
                $"Email : {Email}\n" +
                $"Téléphone perso : {Telephone}";
        }
    }
}
