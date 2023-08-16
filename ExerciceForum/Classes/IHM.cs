using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ExerciceForum.Classes;
namespace ExerciceForum.Classes
{
    internal class IHM
    {
        public void Ihm()
        {
            Console.WriteLine("=== Première étape : Création du forum ===");
            Console.Write("Quel est le nom de ce forum ?");
            string titreForum = Console.ReadLine();
            Console.Write("Ce forum aura-t-il un modérateur ?");
            string yaTilUnModerateur = Console.ReadLine();
            do
            {
                if (yaTilUnModerateur == "Y")
                {
                    Console.WriteLine("=== Affectation d'un modérateur au forum ===");
                    Console.Write("Quel est le nom du modérateur ?");
                    string nomModerateur = Console.ReadLine();
                    Console.Write("Quel est le prénom du modérateur ?");
                    string prenomModerateur = Console.ReadLine();
                    Console.Write("Quel est l'age du modérateur ?");
                    int age = int.Parse(Console.ReadLine());
                    Forum forum = new Forum(titreForum);
                    Moderateur moderateurA = new Moderateur(nomModerateur, prenomModerateur, age);

                    string choix = "";
                    Console.Write(" === Menu Principal === \n");                   
                    do
                    {
                        Console.WriteLine("1. Voir les abonnés");
                        Console.WriteLine("2. Ajouter un abonné");
                        Console.WriteLine("3. Bannir un abonné");
                        Console.WriteLine("4. Voir les nouvelles");
                        Console.WriteLine("5. Consulter une nouvelle");
                        Console.WriteLine("6. Ajouter une nouvelle");
                        Console.WriteLine("7. Répondre à une nouvelle");
                        Console.WriteLine("8. Supprimer une nouvelle");
                        Console.WriteLine("0. Quitter");
                        choix = Console.ReadLine();
                        switch(choix)
                        {
                            case "1":
                                moderateurA.ListerAbonnes();
                                Console.WriteLine("Appuyez sur une touche pour revenir en arrière...");
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine(" === Inscription abonné === \n");
                                Console.Write("nom : ");
                                string nomAbo = Console.ReadLine();
                                Console.Write("prénom : ");
                                string prenomAbo = Console.ReadLine();
                                Console.Write("age : ");
                                int ageAbo = int.Parse(Console.ReadLine());
                                Abonne abonne = new Abonne(prenomAbo,nomAbo,ageAbo);
                                moderateurA.AjouterUnAbonne(abonne);
                                Console.WriteLine("L'abonné a été ajouté avec succés!");                              
                                Console.WriteLine("Appuyez sur une touche pour revenir en arrière...");
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Write("Merci de rentrer le nom de l'abonné : ");
                                string nomAboSup = Console.ReadLine();
                                Console.Write("Merci de rentrer le prénom de l'abonné : ");
                                string prenomAboSup = Console.ReadLine();
                                moderateurA.BannirUnAbonne(nomAboSup, prenomAboSup);
                                break;
                            case "4":
                                moderateurA.ConsulterNouvelles();
                                break;
                            case "5":
                                //L'abonné Grégory Schoemaecker est connecté//
                                var abonneA = Forum.Abonnes.FirstOrDefault(abo => abo.Nom == "Schoemaecker" && abo.Prenom == "Grégory");
                                Console.Write("Choisir la nouvelle à consulter(Notez le sujet à consulter) : ");
                                string sujetAconsulter = Console.ReadLine();
                                if(abonneA != null)
                                {
                                    abonneA.ConsulterUneNouvelle(sujetAconsulter);
                                }                               
                                break;
                            case "6":
                                Console.WriteLine(" === Ajouter une nouvelle === \n");
                                Console.Write("Sujet : ");
                                string sujet = Console.ReadLine();
                                Console.Write("Descriptif : ");
                                string descriptif = Console.ReadLine();
                                Nouvelle nouvelle = new Nouvelle(sujet, descriptif);
                                //L'abonné Grégory Schoemaecker est connecté//
                                abonneA = Forum.Abonnes.FirstOrDefault(abo => abo.Nom == "Schoemaecker" && abo.Prenom == "Grégory");
                                if(abonneA != null)
                                {
                                    abonneA.AjouterUneNouvelle(nouvelle);
                                }                              
                                break;
                            case "7":
                                //L'abonné Grégory Schoemaecker est connecté//
                                abonneA = Forum.Abonnes.FirstOrDefault(abo => abo.Nom == "Schoemaecker" && abo.Prenom == "Grégory");
                                Console.Write("Choisissez le sujet pour votre réponde !");
                                string NumeroSujet = Console.ReadLine();
                                Console.Write("Ecrire une réponse : ");
                                string reponse = Console.ReadLine();
                                if( abonneA != null)
                                {
                                    abonneA.RepondreAUneNouvelle(reponse, NumeroSujet);
                                }                            
                                break;
                            case "8":
                                Console.Write("Choisissez la nouvelle à supprimer(Selectionner le sujet)");
                                NumeroSujet = Console.ReadLine();
                                moderateurA.SupprimerUneNouvelle(NumeroSujet);
                                break;
                            default:
                                break;
                        }
                    } while (choix != "0");
                }
                else if (yaTilUnModerateur == "N")
                {
                    Console.WriteLine("=== Le forum n'a pas de modérateur ===");
                }
            } while (yaTilUnModerateur != "Y" && yaTilUnModerateur != "N");        
        
        }
    }
}
