using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_01_RecapPoly.Classes
{
    internal class Studente : Persona
    {
        public Studente() { }

        public string? Matricola  { get; set; }
        public string? Corso  { get; set; }

        public override string ToString()
        {
            return $"[Studente] {Nome}{Cognome}{CodFis} {Matricola} {Corso}";
        }

        public Studente(string varNome, string varCognome, string varCodFis, string varMatr, string varCorso)
        {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Matricola = varMatr;
            Corso = varCorso;
        }



        public void StampaCartaInt()
            {
                Console.WriteLine("-------------------- *** -------------------");
                Console.WriteLine($" Lo studente: {Nome} {Cognome}");
                Console.WriteLine($" Iscritto al corso di: {Corso}");
                Console.WriteLine("-------------------- *** -------------------");
            }
        }


    }

