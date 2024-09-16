using Lez04_02_Composizioni.Classes;

namespace Lez04_02_Composizioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiore ros = new Fiore();
            Fiore vio = new Fiore();
            Fiore cal = new Fiore();

            Mazzo ma= new Mazzo();
            
            ma.AggiungiFiore(ros);
            ma.AggiungiFiore(vio);
            ma.AggiungiFiore(cal);


        }
    }
}
