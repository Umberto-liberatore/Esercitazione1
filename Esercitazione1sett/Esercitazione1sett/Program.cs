namespace Esercitazione_1_sett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool insAbi = true;
            double operazione;

            while (insAbi)
            {
                Console.WriteLine("\nDimmi cosa vuoi fare:\n- I per inserimento\n- Q per uscire");
                string? inputUtente = Console.ReadLine();

                if (inputUtente is not null)
                    inputUtente = inputUtente.ToUpper();



                switch (inputUtente)
                {

                    case "I":
                        
                          Console.WriteLine("Inserisci primo numero:");
                        double inNum1 = Convert.ToDouble(Console.ReadLine());

                          Console.Write("Inserisci secondo numero:");
                        double inNum2 = Convert.ToDouble(Console.ReadLine());




                            Console.WriteLine("Dimmi che operazione vuoi fare :\n- somma\n- sottrazione\n- moltiplicazione\n- divisione");

                            string? inputUt = Console.ReadLine();



                            switch (inputUt)
                            {
                                case "somma":

                                    operazione = inNum1 + inNum2;
                                    Console.Write("la somma e' " + operazione);
                                    break;

                                case "sottrazione":

                                    operazione = inNum1 - inNum2;
                                    Console.Write("la differenza e' " + operazione);
                                    break;


                                case "moltiplicazione":

                                    operazione = inNum1 * inNum2;
                                    Console.Write("il prodotto e' " + operazione);
                                    break;

                                case "divisione":

                                    if (inNum2 == 0)
                                        Console.Write("NON è POSSIBILE ESEGUIRE LA DIVISIONE");
                                    else
                                    {
                                        operazione = inNum1 / inNum2;

                                        Console.Write($"il rapporto e'  {operazione}");
                                    }
                                    break;

                            }
                            break;
                        

                        



                    case "Q":
                            insAbi = !insAbi;
                            break;
                        default:
                            Console.WriteLine("Comando non riconosciuto");
                            break;


                    }
                }
               

            }





        }
   }
    

// a che altezza del codice va inserito il controllo dell'inserimento di una lettera (quindi un carattere non numerico

