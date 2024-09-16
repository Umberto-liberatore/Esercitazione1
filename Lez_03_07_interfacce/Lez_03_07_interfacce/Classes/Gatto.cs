using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_07_interfacce.Classes
{
    internal class Gatto : IAnimale
    {
        public bool HasPelo { get; set; }

        public string? Colore { get; set; }

        public string? numZampe { get; set; }

        public void tipoMovimento()
        {
            Console.WriteLine("cammina");
        }

        public void versoEmesso()
        {
            Console.WriteLine("miao miao");
        }
    }
}
