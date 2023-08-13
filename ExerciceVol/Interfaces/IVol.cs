using ExerciceVol.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Interfaces
{
    internal interface IVol
    {
        string Liste_Successeurs(string villeDepart); //Retourne une liste contenant les villes d'arrivées
        void Appartient(); //Verifie si une ville appartient au plan du vol que ce soit comme ville d'arrivé ou de départ
        void Affiche(); //Affiche tous les vols directs
    }
}
