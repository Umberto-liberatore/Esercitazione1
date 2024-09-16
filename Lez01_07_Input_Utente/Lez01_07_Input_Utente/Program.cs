namespace Lez01_07_Input_Utente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
    * Creare un programma che in input prenda il nome, cognome ed età dell'utente e che in output lo saluti e gli dica se è maggiorenne o minorenne.
    */

            Console.Write("Inserisci il nome: ");
            string? inputNome= Console.ReadLine();


            Console.WriteLine("inserisci il cognome: ");
            string? inputCognome = Console.ReadLine();

            Console.WriteLine("inserisci l' età: ");
            //string? inputEta = Console.ReadLine();
            //int eta = Convert.ToInt32(inputEta); //ottimizzo

            try
            {
                int eta = Convert.ToInt32(Console.ReadLine());
                string? risultato;

                if (eta > 18)
                {
                    risultato = "Maggiorenne";
                }
                else
                {
                    risultato = "Minorenne";

                }

                Console.WriteLine($"Ciao {inputNome} {inputCognome}, sei {risultato}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Errore, formato non ammesso");
            }
            catch (OverflowException oe) {
          
                Console.WriteLine("ERRORE, numero troppo grnade");
            }

            catch (Exception ex){
                    Console.WriteLine("Errore");
                }
            



        }
    }
}
