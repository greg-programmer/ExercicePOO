using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal class Forum
    {
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public static List<Abonne> Abonnes { get; set; } = new List<Abonne>();
        public static List<Nouvelle> Nouvelles { get; set; } = new List<Nouvelle>();   
        public Moderateur Moderateur { get; set; }
       
       //Rajouter un tableau d'abonnés//
    }
}
