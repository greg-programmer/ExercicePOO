using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classe
{
    internal class Client
    {
       private int Id { get; set; } 
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private string Phone { get; set; }

        public Client(int id, string lastName, string firstName, string phone)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }
    }
}
