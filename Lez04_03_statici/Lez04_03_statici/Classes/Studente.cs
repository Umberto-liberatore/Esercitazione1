using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_03_statici.Classes
{
    internal class Studente
    {
        //public static int Contatore { get; private set; } = 3;

        private static int contatore = 0;
        public string? Nominativo { get; set; }
        public string? Matricola { get; set; }

        public Studente() 
        {
            contatore++;
        }

        public static int getContatore()
        {
            return contatore;
         }
    }
}
