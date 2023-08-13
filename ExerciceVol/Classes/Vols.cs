using ExerciceVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Classes
{
    internal class Vols : IVol
    {
       List<VolDirect> Vol { get; set; } = new List<VolDirect>() 
        {
           new VolDirect("Paris", "Marseille", "12", new DateTime()),
           new VolDirect("Marseille", "Barcelone", "22", new DateTime()),
           new VolDirect("Toulouse", "Barcelone", "22", new DateTime()),
           new VolDirect("Paris", "Toulouse", "17", new DateTime()),
           new VolDirect("Paris", "Barcelone", "22", new DateTime()),
           new VolDirect("Lille", "Barcelone", "22", new DateTime()),
           new VolDirect("Toulouse", "Paris", "22", new DateTime()),
        };
        List<string> VolNamesArrived { get; set; } = new List<string>() { "Paris","Barcelone","Rome","Venise","Toulouse","Lille","Madrid"};

        public string Liste_Successeurs(string villeDepart)
        {
            List<String> strings = new List<String>();
            foreach (var item in Vol)
            {
                if(item.Start == villeDepart)
                {
                    strings.Add(item.Arrived);
                }
            }
           return "La liste des destinations à partir de" + " " + villeDepart +" est : {'" + String.Join("', '",strings) + "'}";//Gérer l'affichage des villes d'arrivé           
        }
        public void Affiche()
        {
            foreach (var volDirect in Vol)
            {
                Console.WriteLine(volDirect);
            }
        }

        //Écrire une méthode Appartient qui vérifie si une ville appartient au plan du vol que ce soit comme ville d’arrivée ou de départ
        public void Appartient()
        {
            bool appartient = false;
           var a = new List<VolDirect>();
            foreach (var item in VolNamesArrived)
            {
               a = Vol.Where(volDirects => volDirects.Start == item || volDirects.Arrived == item).ToList();
                if(a.Count == 0)
                {
                    Console.WriteLine($"La ville de {item} ne fait pas partie du plan de de vol !");
                }
                else
                {
                    Console.WriteLine($"La ville de {item} fait partie du plan de vol !");
                }              

           }     
            
        }
    }
}
