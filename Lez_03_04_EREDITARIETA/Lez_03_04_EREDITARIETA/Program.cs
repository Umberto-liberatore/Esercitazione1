using Lez_03_04_EREDITARIETA.Classes;

namespace Lez_03_04_EREDITARIETA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente gio = new Studente("Giovanni", "Pace", "AB1234");
            gio.StampaDettaglio();

            Docente mar = new Docente();
            mar.Nome = "Mario";
            mar.Cognome = "Rossi";
            mar.Dipartimento = "Fisica";

            mar.StampaDettaglio();


        }
    }
}
