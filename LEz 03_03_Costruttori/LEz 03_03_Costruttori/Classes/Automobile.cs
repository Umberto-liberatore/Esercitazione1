using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEz_03_03_Costruttori.Classes
{
    internal class Automobile
    {
        public string Marca { get; set; } = null;
        public int cilindrata { get; set; } = 0;

        public string colore { get; set; } = null;


        public Automobile (string varMarca, int varCilindrata, string varColore) 
        {

            this.Marca = varMarca;
            if (varCilindrata >0)
            this.cilindrata = varCilindrata;
            this.colore = varColore;


            Console.WriteLine("Sono il costruttore di con 3 parmaetri");
        }


        public Automobile ()
        {
            Console.WriteLine("sono il costruttore di default");
        }


        public Automobile(string varMarca, string varColore)
        {

            this.Marca = varMarca;
          
            this.colore = varColore;


            Console.WriteLine("Sono il costruttore di con 2 parmaetri");
        }

        public void StampaDettaglio()
        {
            Console.WriteLine($"[Automobile] {Marca} {cilindrata}{colore}");
        }

        public override string ToString()
        {
            return $" [Automobile] {Marca} {cilindrata}{colore}";
        }
    }
}
