using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_09_Poly
{
    internal class Moto : Veicolo

    {
            public bool HasBauletto { get; set; }
            public bool HasSidecar { get; set; }
            public Moto() 
        {
            Marca = "ducati";
            Modello = "HyB";
            Colore = "rossa";

        }
        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Moto] {Targa} {Colore} {Marca} {Modello} {HasSidecar} {HasBauletto}");
        }

        public override void Accensione()
        {
            Console.WriteLine("[MOTO] Bruuuuuuuuuuuum...");
          
        }

   
}
}
