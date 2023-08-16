using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal class Nouvelle
    {
        public string Sujet { get; set; }   
        public string Descriptif { get; set; }
        public string Reponse { get; set; } = "";
        public Nouvelle(string sujet, string descriptif)
        {
            Sujet = sujet;
            Descriptif = descriptif;
        }
        public override string ToString()
        {
            string concatReponse = "";
            if (Reponse != "")
            {
                concatReponse = $"Reponse : {Reponse}";
            }
            return $"Sujet : {Sujet} Descriptif : {Descriptif}" + concatReponse;
        }
    }
}
