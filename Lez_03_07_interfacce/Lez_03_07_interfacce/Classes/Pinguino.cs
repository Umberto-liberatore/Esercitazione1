using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_07_interfacce.Classes
{
    internal class Pinguino : IAnimale
    {
        public string Ping { get; set; }

        public void tipoMovimento()
        {
            Console.WriteLine("ciondola");
        }

        public void versoEmesso()
        {
            Console.WriteLine("boh..");
        }
    }
}
