namespace Lez01_05_Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nominativo = null!;
            //nominativo = "Giovanni";
            //Console.WriteLine(nominativo);

            //--------------
            //Console.WriteLine("Giovanni" + "Pace");

            //int a = 5;
            //int b = 20;

            //Console.WriteLine("La somma dei numeri è:" + a + b );
            //Console.WriteLine("La somma dei numeri è:" + (a + b));
            //Console.WriteLine(a +b + "è La somma dei numeri");


            /*
             * Scrivere un programma che mandi in output le seguenti due stringhe:
             * 
             * Giovanni PACE è 37 anni vecchio ed ha una temperatura corporea di 36.2°
             * Mario Rossi è 35 anni vecchio ed ha una temperatura corporea di 37.3°
             * 
             */

            //String nome1 = "Giovanni";
            //String Cognome1= "Pace";

            //String nome2 = "Mario";
            //String Cognome2 = "Rossi";

            //int eta1 = 37;
            //int eta2 = 35;

            //float temperatura = 36.2f;
            //float temperatura2 = 37.3f;

            //Console.WriteLine(nome1 + Cognome1 +" e' " + eta1 + " anni vecchio ed ha una temperatura corporea di :"+ temperatura+ "°");
            //Console.WriteLine(nome2 + Cognome2 + " e' " + eta2 + " anni vecchio ed ha una temperatura corporea di :" + temperatura2 + "°");

            //----------------------------------------

            // Console.WriteLine($"Guarda la somma di questi numeri, è: {5 + 6}");


            //string nominativo = "Giovanni Pace";
            //Console.WriteLine($"La lunghezza del nome {nominativo} è: {nominativo.Length}");
            //int Lunghezza = nominativo.Length;
            //Console.WriteLine($"La lunghezza del nome {nominativo} è: {Lunghezza}");

            //-------------------------
            //string? frase = "Mi piace tanto \"programmare\"";
            //Console.WriteLine(frase);

            //char prova = 'A';


            //----------------------------------


            String? frase = "Sono Giovanni e mi piace programmare";
             Console.WriteLine(frase.IndexOf("Giovanni"));

            if(frase.IndexOf("Giovanni") >-1)
            {
                Console.WriteLine("Trovato");
            }
            else
            {
                Console.WriteLine("Non trovato");
            }

        } 
    }
}
