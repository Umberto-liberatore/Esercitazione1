using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_01_RecapPoly.Classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }
        public bool IsPresidente { get; set; } = false;

        public override string ToString()
        {
            return $"[Docente] {Nome}{Cognome}{CodFis} {Dipartimento} {IsPresidente}";
        }


        public Docente(string varNome, string varCognome, string varCodFis, string varDipartimento, bool varPresidente)
        {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Dipartimento = varDipartimento;
            IsPresidente = varPresidente;
        }


        public void DettaglioDocente()
        {
            Console.WriteLine("-------------------- Docente -------------------");
            Console.WriteLine($" Il docente: {Nome} {Cognome}");
            Console.WriteLine($" Insegno al dipartimento di: {Dipartimento}");
            Console.WriteLine("-------------------- *** -------------------");
        }
    }
}

