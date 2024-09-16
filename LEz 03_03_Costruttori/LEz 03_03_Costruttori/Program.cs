using LEz_03_03_Costruttori.Classes;

namespace LEz_03_03_Costruttori
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Automobile focus = new Automobile();
            //focus.Marca = "FORD";
            //focus.cilindrata = 1300;
            //focus.colore = "Rosso";

            Automobile panda = new Automobile();
            Automobile qashqai = new Automobile("nissan","giallo");
            Automobile ypsilon = new Automobile("lancia", 1200, "Giallo");
        }
    }
}
