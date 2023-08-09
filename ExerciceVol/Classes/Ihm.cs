using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVol.Classes
{
    internal class Ihm
    {
        public void IHM()
        {
            List<VolDirect> Directs = new List<VolDirect>();
            VolDirect DirectA = new VolDirect("Paris", "Marseille", "12", new DateTime());
            VolDirect DirectB = new VolDirect("Paris", "Toulouse", "17", new DateTime());
            VolDirect DirectC = new VolDirect("Paris", "Barcelone", "22", new DateTime());
            Console.WriteLine(DirectA);
            Console.WriteLine(DirectB);
            Console.WriteLine(DirectC);
        }     
    }
}
