namespace Lez_03_09_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veicolo aut = new Automobile();
            //Veicolo mot = new Moto();

            //Veicolo vei = new Veicolo();


            Automobile focus = new Automobile();
            Automobile panda = new Automobile();

            Moto honda = new Moto();
            Moto ducati = new Moto();

            List<Veicolo> elenco = new List<Veicolo>();
            elenco.Add(focus);
            elenco.Add(panda);
            elenco.Add(honda);
            elenco.Add(ducati);

            foreach(Veicolo vei in elenco)
            {
                vei.Accensione();

            }




        }
    }
}
