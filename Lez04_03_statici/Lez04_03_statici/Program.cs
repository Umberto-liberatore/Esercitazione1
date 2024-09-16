using Lez04_03_statici.Classes;

namespace Lez04_03_statici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Studente uno = new Studente();
            Studente due = new Studente();

           // Studente.Contatore = 4; // non possibile valorizzare perchè private

            Console.WriteLine(Studente.getContatore());
        }
    }
}
