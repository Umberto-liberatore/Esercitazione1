using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_02_05_Classi_oggetti.classes
{
    internal class Automobile
    {

        public string? modello;
        public string? colore;
        public int? cilindrata;


        public void stampaDettaglio()
        {
            Console.WriteLine($"Modello: {modello}\n colore: {colore}\n  cilindrata: {cilindrata}\n");
        }
    }
}
