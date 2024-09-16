using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lez_03_09_Poly
{
    internal class Automobile : Veicolo
   
        {
            public int Porte { get; set; }

            public int Posti { get; set; }

        public override void StampaDettaglio()
            {
                Console.WriteLine($"[Automobile] {Colore} {Marca} {Modello} {Targa} {Posti} {Porte}");
            }
        }
}
