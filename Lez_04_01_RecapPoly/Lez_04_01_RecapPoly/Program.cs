using Lez_04_01_RecapPoly.Classes;

namespace Lez_04_01_RecapPoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Studente("Giovanni", "Pace", "PCAGNN", "AB1234", "Informatica");


            //Studente stu = (Studente)gio;
            //stu.StampaCartaInt();

            Persona val = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");

            Persona doc = new Docente("Marika", "Mariko", "MRKMRK", "Informatica", true); //Binding dinamico (non so a priori che tipo è, non so quale è la dimensione di memoria)

            List<Persona> elenco = new List<Persona>();
            elenco.Add(gio);
            elenco.Add(val);
            elenco.Add(doc);

            //foreach (Persona per in elenco)
            //{
            //    if (per.GetType() == typeof(Studente))
            //    {
            //        Studente stu = (Studente)per;
            //        stu.StampaCartaInt();
            //    }


            //    if (per.GetType() == typeof(Docente))
            //    {
            //        Docente d = (Docente)per;
            //        d.DettaglioDocente();
            //    }
            //    Console.WriteLine(per.ToString());


            //---------------------------------------------
            Studente chic = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");
            Studente arp = new Studente("ari", "rossi", "VLRVRD", "AB1235", "Ingegneria");

            Docente ris = new Docente("marco", "gialli", "VLRVRD", "AB1235", true);

            Universita iemacademy = new Universita();
            iemacademy.AggiungiStudente(chic);
            iemacademy.AggiungiStudente(chic);
            iemacademy.AggiungiDocente(ris);

            iemacademy.StampaTutti();
            iemacademy.StampaStudenti();
            iemacademy.StampaDocenti();
            iemacademy.StampaCertificatiStudentiElenco();




        }



        }
    }

