using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace lez01_03_variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int eta = 37;
            //Console.WriteLine(eta);

            ////int eta_due; //dichiarazione
            //eta_due = 38; //assegnazione

            //Console.WriteLine(eta_due);
            //--------------------------------------------------


            ////string nome = "Giovanni";
            ////Console.WriteLine(nome);
            ////string Cognome = "Pace";
            ////Console.WriteLine(Cognome);

            //String? secondo_nome = null;
            //secondo_nome = "Carmine";
            //Console.WriteLine(secondo_nome);

            //---------------------------------------------------


            // OPERAZIONI

            // Console.WriteLine(2 + 5);


            //---------------------------------------------------


            /*
             * if(Condizioni)
             * {
             *    ......
             * }
             * 
             * else
             * {
             *   ......
             * }
            */

            //int eta =12;
            // if (eta>=18)
            //     {
            //    Console.WriteLine("maggiorenne"); ;
            //}
            //else
            //{
            //    Console.WriteLine("minorenne");
            //}


            //--------------------------------------------

            //int eta = 1400;

            //if (eta < 120)
            //{

            //    if (eta >= 0)
            //    {
            //        if (eta >= 18)
            //        {
            //            Console.WriteLine("maggiorenne"); ;
            //        }
            //        else
            //        {
            //            Console.WriteLine("minorenne");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERRORE età troppo bassa");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("ERRORE età troppo alta");
            //}


            //-------------------------------------------------


            // logica BOOLEANA

            //AND

            //int eta = 3000;
            //if (eta > 00 && eta < 120)
            //{
            //    Console.WriteLine("Verifica MAggiorenne");

            //}
            //else
            //{
            //    Console.WriteLine("ERRORE ");
            //}



            //---------------------------------------------------

            // logica BOOLEANA

            //OR


            int eta = 23;
                if (eta < 0 || eta >= 120)
            {
                Console.WriteLine("ERRORE");
            }
            else
            {
                Console.WriteLine("Verifica maggiorenne");
            }


            // logica BOOLEANA

            //NOT 
            bool hasPelo = false;
            Console.WriteLine(hasPelo);

        }
    }
}