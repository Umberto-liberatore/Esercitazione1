using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_09_Poly
{
    internal  class Veicolo
    {
        
        public string? Marca { get; set; }
        public string? Modello { get; set; }

        public string? Targa { get; set; }
        public string? Colore { get; set; }

        public Veicolo() { }


        public virtual void Accensione()
        {
            Console.WriteLine("[VEICOLO] Accensione");
        }
        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Veicolo] {Marca} {Modello} {Targa} {Colore}");
        }
    }
}
