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
