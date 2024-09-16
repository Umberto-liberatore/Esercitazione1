using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_01_RecapPoly.Classes
{
    internal class Universita
    {
        public string? Nome { get; set; }
        public string? Indirizzo { get; set; }


        public List<Persona> Elenco { get; set; } = new List<Persona>();  // Aggregazione

        public void AggiungiStudente(Studente ObjStu)
        {
            Elenco.Add(ObjStu);
            Console.WriteLine("Studente aggiunto con successo");
        }

        public void AggiungiDocente(Docente ObjDoc)
        {
            Elenco.Add(ObjDoc);
            Console.WriteLine("Docente aggiunto con successo");
        }

        public void StampaTutti()

        {
            foreach (Persona per in Elenco)
            {
                Console.WriteLine(per.ToString());
            }
        }

        public void StampaStudenti()
        {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Studente))
                    Console.WriteLine(per.ToString());

            }
        }

        public void StampaDocenti()
        {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Docente))
                    Console.WriteLine(per.ToString());

            }
        }



        public void StampaCertificatiStudentiElenco()
        {
            foreach(Persona per in Elenco)
            {
                if(per.GetType() == typeof(Studente))
                {
                    Studente stu =(Studente)per;
                    stu.StampaCartaInt();
                }
            }
        }
    }
}
