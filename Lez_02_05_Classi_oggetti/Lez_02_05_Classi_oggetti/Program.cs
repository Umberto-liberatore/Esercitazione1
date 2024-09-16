using Lez_02_05_Classi_oggetti.classes;

namespace Lez_02_05_Classi_oggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Automobile ford = new Automobile();
            ford.colore = "Blu";
            ford.cilindrata = 2000;
            ford.modello = "Focus";
            ford.stampaDettaglio();


            Automobile fiat = new Automobile();
            fiat.colore = "Giallo";
            fiat.cilindrata = 1200;
            fiat.modello = "Focus";
            fiat.stampaDettaglio();

            Automobile ferrari = new Automobile();
            ferrari.colore = "Rossa";
            ferrari.cilindrata = 3000;
            ferrari.modello = "Modena";
            ferrari.stampaDettaglio();


            Console.WriteLine(ferrari.colore);

        }
        
            
        
    }
}
