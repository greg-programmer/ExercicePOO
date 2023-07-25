using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceScientifique.Classe
{
    internal static class Ihm
    {
        public static void IHM()
        {
            Travailleur travailleur = new Travailleur("Schoemaecker", "Aurélie", "0657575757777"
                , "lilie@gmail.com", "Mairie", "32 rue des la bastille", "070606461606");
            Console.WriteLine(travailleur);
            Console.WriteLine();
            Scientifique scientifique = new Scientifique("Schoemaecker", "Bastien", "0657575757",
                "lilie@gmail.com", "Mairie", "32 rue des la bastille", "070606461606", "Chimie", "Théorique");
            Console.WriteLine(scientifique);
        }
        
    }
}
