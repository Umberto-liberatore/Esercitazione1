using System.ComponentModel.DataAnnotations;

namespace Lez02_03_ContenitoriDinamici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List<string> lista = new List<string>();
            //    lista.Add("Giovanni");
            //    lista.Add("Valeria");
            //    lista.Add("Mario");

            //    for (int i = 0; i < lista.Count; i++) 
            //    {

            //        Console.WriteLine(lista[i]);
            //    }

            //-----------------------------------------------


            /*
            * Creare un sistema di input che mi permetta di aggiungere invitati ad una lista, 
            * che abbia una funzione di stampa della lista e che mi permetta di interrompere il programma digitando Q
            */


            bool insAbi = true;

            List<string> elenco = new List<string>();



            while (insAbi)
            {
                Console.WriteLine("Dimmi cosa vuoi fare:\n- I per inserimento\n- S per la stampa\n- Q per uscire");
                string? inputUtente = Console.ReadLine();
            

            if (inputUtente is not null)
                inputUtente = inputUtente.ToUpper();

            switch (inputUtente)
            {
                case "I":
                        Console.WriteLine("Dammi il nome:");
                        string?varNome = Console.ReadLine();
                        if (varNome is not null && !varNome.Trim().Equals(""))
                        {
                            elenco.Add(varNome);
                            Console.WriteLine("Valore inserito con successo");
                        }
                        else
                            Console.WriteLine("non ammette valori vuoti");
                        break;

                case "S":

                        for(int i = 0; i<elenco.Count; i++)
                        {
                            Console.WriteLine($"{elenco[i]}");

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


        

            //List<string> lista = new List<string>();
            //lista.Add("Giovanni");
            //lista.Add("Valeria");
            //lista.Add("Mario");

            //for (int i = 0; i < lista.Count; i++) 
            // {

            //       Console.WriteLine(lista[i]);
            //    }

        }




    }
}
