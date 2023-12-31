﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForum.Classes
{
    internal class Forum
    {
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public static List<Abonne> Abonnes { get; set; } = new List<Abonne>();
        public static List<Nouvelle> Nouvelles { get; set; } = new List<Nouvelle>();   
        public Moderateur Moderateur { get; set; }

        public Forum(string nom)
        {
            Nom = nom;           
        }
        public override string ToString()
        {
            return $"Titre du forum : {Nom} Date De Création : {DateCreation}";
        }

    }
}
