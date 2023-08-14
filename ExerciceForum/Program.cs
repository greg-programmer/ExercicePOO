// See https://aka.ms/new-console-template for more information
using ExerciceForum.Classes;

Console.WriteLine("Hello, World!");
Abonne abonne = new Abonne("Grégory","Schoemaecker",37);
Abonne abonneB = new Abonne("Bastien", "Schoemaecker", 8);
Abonne abonneC = new Abonne("Céléna", "Schoemaecker", 6);
Nouvelle nouvelle = new Nouvelle("Q1","salut");
Nouvelle nouvelle2 = new Nouvelle("Q2", "tu vas");
Nouvelle nouvelle3 = new Nouvelle("Q3", "bien?");
abonne.AjouterUneNouvelle(nouvelle);
abonne.AjouterUneNouvelle(nouvelle2);
abonne.AjouterUneNouvelle(nouvelle3);
abonne.ConsulterNouvelle();
Moderateur moderateur = new Moderateur("Aurélie", "Schoemaecker", 36);
moderateur.SupprimerUneNouvelle("Q2");
abonne.ConsulterNouvelle();
moderateur.BannirUnAbonne("Grégory", "Schoemaecker");
moderateur.AjouterUnAbonne(abonneB);
moderateur.AjouterUnAbonne(abonneC);
moderateur.ListerAbonnes();
moderateur.ConsulterNouvelle();