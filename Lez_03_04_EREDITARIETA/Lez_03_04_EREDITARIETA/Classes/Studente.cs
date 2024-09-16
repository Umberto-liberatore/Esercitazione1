using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_04_EREDITARIETA.Classes
{
    internal class Studente: Persona
    {

        public string? Matricola { get; set; }


        public Studente() 
        {
            Console.WriteLine("Sono il costruttore di Studente");
        }

        public Studente (string varNome , string varCognome , string varMatricola)
        {
            this.Nome = varNome;

            this.Cognome = varCognome;

            this.Matricola= varMatricola;
        }


        public void StampaDettaglio()
        {
            Console.WriteLine($"" + $"[Studente] {Nome} {Cognome} {Matricola}");
        }
    }
}
