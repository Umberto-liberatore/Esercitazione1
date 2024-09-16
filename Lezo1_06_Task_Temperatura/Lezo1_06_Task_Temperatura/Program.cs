namespace Lezo1_06_Task_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di controllo accessi al risorante, in input (sottoforma di variabile) ci sara la temperatura.
             * 
             * Se la temperartura è maggiore o uguale a 37.5° non permettere l'accesso al ristorante.
             * ATTENZIONE: Non ci vuole un medico per stabilire che al di sotto dei 34° potrebbe esserci qualche problema, oppure al di sopra dei 42 potrebbe esserci qualche sintomo di una apocalisse zombie (a cui non dovrebbe essere permesso l'accesso). Restituire un errore.
*/

           
           Console.WriteLine("Ciao, inserisci LA TEMPERATURA");
           string? inputUtente= Console.ReadLine();
            try
            {
                double temperatura = Convert.ToDouble(inputUtente);
                Console.WriteLine($" .....{temperatura}");

                if (temperatura < 34 || temperatura >= 37.5f)
                {
                    Console.WriteLine("non si può accedere al risorante");

                }
                else
                {
                    Console.WriteLine("Avanti");
                }
            }
            catch
            {
                Console.WriteLine("ERRORE DI INPUT");
            } 

            //--------------------------------------------


            //Console.WriteLine("Ciao, inserisci il tuo nome");
            //string? inputUtente= Console.ReadLine();
            //Console.WriteLine($"Benvenuto {inputUtente}");

            //--------------------------------------------------------

            //    Console.WriteLine("Inserisci la temperatura:");
            //string? inputUtente = Console.ReadLine();
            //try
            //{
            //    double temperatura = Convert.ToDouble(inputUtente);
            //    Console.WriteLine($" .....{temperatura}");

            //}
            //catch
            //{
            //    Console.WriteLine("ERRORE DI INPUT");
            //} 






        }
        }
}
