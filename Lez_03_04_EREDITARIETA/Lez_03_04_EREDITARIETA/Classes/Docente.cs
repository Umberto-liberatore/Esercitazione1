using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_04_EREDITARIETA.Classes
{
    internal class Docente :Persona
    {

        public string?  Dipartimento { get; set; }

        public override void stampaDettaglio()
        {
            Console.WriteLine($"[Docente] {Nome} {Cognome} {Dipartimento}");    
        }
    }
}
