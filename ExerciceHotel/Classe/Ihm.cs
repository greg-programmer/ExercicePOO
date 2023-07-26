using ExerciceHotel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Ihm 
    {
      public void IHM()
        {

            Hotel hotel = new Hotel();
            // ======= Initilisation des chambres de l'hotel =======//
            Chambre chambreA = new Chambre(10, EChambre.libre, 2, 45);
            Chambre chambreB = new Chambre(10, EChambre.libre, 3, 45);
            Chambre chambreC = new Chambre(10, EChambre.libre, 1, 45);
            Chambre chambreD = new Chambre(10, EChambre.libre, 2, 45);
            Chambre chambreE = new Chambre(10, EChambre.libre, 2, 45);
            Chambre chambreF = new Chambre(10, EChambre.libre, 2, 45);
            Chambre chambreG = new Chambre(10, EChambre.libre, 3, 45);
            Chambre chambreH = new Chambre(10, EChambre.libre, 2, 45);
            Chambre chambreI = new Chambre(10, EChambre.libre, 2, 45);
            hotel.AjouterLaListeDesChambres(chambreA);
            hotel.AjouterLaListeDesChambres(chambreB);
            hotel.AjouterLaListeDesChambres(chambreC);
            hotel.AjouterLaListeDesChambres(chambreD);
            hotel.AjouterLaListeDesChambres(chambreE);
            hotel.AjouterLaListeDesChambres(chambreF);
            hotel.AjouterLaListeDesChambres(chambreG);
            hotel.AjouterLaListeDesChambres(chambreH);
            hotel.AjouterLaListeDesChambres(chambreI);
            //==========================================================//
            Client clientA = new Client(1,"Schoemaecker","Grégory","0606060606");
            hotel.AjouterUnClient(clientA);
            Client clientB = new Client(2, "Schoemaecker", "Aurélie", "0606060606");
            hotel.AjouterUnClient(clientB);
            foreach (var item in hotel.Clients)
            {
                Console.WriteLine(item);
            }
         

        }
    }
}
