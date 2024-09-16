using Lez_03_02_Properies.Classes;

namespace Lez_03_02_Properies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottiglia acqua  =new Bottiglia();
            acqua.MAteriale = "PET";
            acqua.Marca = "Santa Lucia";
            Console.Write(acqua.Marca);
        }
    }
}
