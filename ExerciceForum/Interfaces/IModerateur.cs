﻿using ExerciceForum.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Interfaces
{
    internal interface IModerateur
    {
        void SupprimerUneNouvelle(string sujet);
        void BannirUnAbonne(string Nom, string prenom);
        void AjouterUnAbonne(Abonne abonne);
        void ConsulterNouvelles();
        void ListerAbonnes();

    }
}
