using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Task.classes
{
    internal abstract class Veicolo
    {
        
        public string? Marca { get; set; }
        public string? Modello { get; set; }

        public string? Targa { get; set; }
        public string? Colore { get; set; }

        public Veicolo() { }


        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Veicolo] {Marca} {Modello} {Targa} {Colore}");
        }
    }
}
