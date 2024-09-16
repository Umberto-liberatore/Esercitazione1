using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1_1_sett.Classes
{
    internal class Studente
    {

        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public double Voto { get; set; }

        public Studente() { }

        public Studente(string varNome, string varCognome, double varVoto)
        {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }
        public List<Studente> Elenco { get; set; } = new List<Studente>();
        public void AggiungiStudente(Studente objStu)
        {
            Elenco.Add(objStu);
            Console.WriteLine("Studente aggiunto con successo");
        }


        public void StampaStudente()
        {
            foreach (Studente stu in Elenco)
            {
                Console.WriteLine(stu.ToString());
            }
        }
    }
}
