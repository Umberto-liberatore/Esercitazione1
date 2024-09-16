namespace Lez02_02_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] elenco = { 1, 2, 45, 56 };
            //elenco[2] = 777;
            //Console.WriteLine(elenco[4]);

            //-------------------------------------


            //int[] elencoDue = new int[5];
            //elencoDue[0] = 23;
            //elencoDue[1] = 5;
            //elencoDue[2] = 265;
            //elencoDue[3] = 2;
            //elencoDue[4] = 2333;

            ////Console.WriteLine(elencoDue.Length);
            //int i = 0;

            //while (i< elencoDue.Length)
            //{
            //    Console.WriteLine(elencoDue[i]);
            //    i++;
            //}


            //--------------------------------------

            //string[] elencoAuto = { "BMW", "Maserati", "LAmborghini", "Fiat" };
            //int i = 0;
            //while (i< elencoAuto.Length)
            //{
            //    Console.WriteLine(elencoAuto[i]);
            //   i++;
            //}



            //-------------------------------------------

            //string[] elencoAuto = { "BMW", "Maserati", "Lamborghini", "Fiat", "Lamborghini" };

            //int i = 0;
            //int contatore = 0;
            //while (i < elencoAuto.Length)
            //{

            //    if (elencoAuto[i].Equals("Lamborghini"))
            //        contatore++;


            //    i++;
            //}
            //Console.WriteLine(contatore);        

            //---------------------------------------------


            //string[] garage = { "BMW", "Maserati", "Lamborghini", "Fiat", "Lamborghini" };

            //Array.Sort(garage);

            //foreach (string auto in garage)
            //{
            //    Console.WriteLine(auto);
            //}


            //---------------------------------------------------

            //string invitati = "Giovanni, Mario, Marika, Valeria";

            //string[] arrayInvitati = invitati.Split(',');

            //foreach (string persona in arrayInvitati) 
            //{

            //    Console.WriteLine(persona); 


            //}



            //---------------------------------------------------------
            //string invitati = "Giovanni, Mario, Marika, Valeria";
            //string[] arrayInvitati = invitati.Split(',');
            // string nominativo = "Giovanni";
            // Console.WriteLine( nominativo[nominativo.length -1]);

            //----------------------------------------------------------

            //string invitati = "Giovanni, Mario, Marika, Valeria";
            //string[] arrayInvitati = invitati.Split(',');
            //int i = 0;
            //while (i < arrayInvitati.Length)
            //{
            //    Console.WriteLine(arrayInvitati[i][0]);
            //    i++;
            //}

            //------------------------------------------------

            string[] garage = { "BMW", "Maserati", "Lamborghini", "Fiat", "Lamborghini" };

            for (int i = 0; i < garage.Length; i++)
            {
                Console.WriteLine(garage[i]);
            }
        }
    }
}
