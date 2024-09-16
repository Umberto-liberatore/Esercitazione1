using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_04_EREDITARIETA.Classes
{
    internal class Persona
    {
        public string? Nome { get; set; }

        public string? Cognome { get; set; }

        public Persona() { }
        public Persona (string varNome, string varCognome)
        {
            this.Nome= varNome;
            this.Cognome= varCognome;
        }


        public void StampaDettaglio() 
        { 
        Console.WriteLine($"[Persona] {Nome} {Cognome}");
        }


        public virtual void stampaDettaglio() 
        { 
        Console.WriteLine($"[Persona] {Nome} {Cognome}");
        }
    }
}
