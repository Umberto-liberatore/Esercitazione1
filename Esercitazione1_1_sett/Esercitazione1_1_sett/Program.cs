using Esercitazione1_1_sett.Classes;

namespace Esercitazione1_1_sett
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Studente umb = new Studente("Giovanni", "Pace", 30);
            Studente luc = new Studente("Valeria", "Verdi", 26);

            List<Studente> elenco = new List<Studente>();
            elenco.Add(umb);
            elenco.Add(luc);
        }
    }
}
