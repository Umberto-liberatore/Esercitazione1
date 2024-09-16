namespace lez00_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SINGOLA LINEA DI COMMENTO
            /* 
             * Commento 
             * multilinea
             */

#if DEBUG
            Console.WriteLine("Sono in modalità debug");
#elif RELEASE
            
            Console.WriteLine("Sono in modalità debug");
#endif
            // ctrl + D DUPLICARE RIGA SELEZIONATA
            // ctrl + K +C COMMENTARE
            // ctrl + K +D DECOMMENTARE RIGA SELEZIONATA
            // CTRL + ù COMMENTA E DECOMMENTA
            Console.WriteLine("Hello world 1");
            Console.WriteLine("Hello world 2");

            Console.ReadLine();
            Console.WriteLine("Ciao");
            Console.WriteLine("Ciao");

            Console.ReadLine();



        }
    }
}
