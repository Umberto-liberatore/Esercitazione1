using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Task.classes
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
                Console.WriteLine($"[Moto] {Colore} {Marca} {Modello} {HasBauletto} {HasSidecar}");
            }
        }

    internal class Moto
    {
    }
}
}
