using ExerciceForum.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Interfaces
{
    internal interface IAbonne
    {
        void AjouterUneNouvelle(Nouvelle nouvelle);
        void ConsulterNouvelles();
        void ConsulterUneNouvelle(string sujetAconsulter);
        void RepondreAUneNouvelle(string reponse, string Sujet);
    }
}
