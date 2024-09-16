namespace Lez_01_08_Controlli_Complessi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string provincia = "BO";

            //if (provincia.Equals("AQ"))
            //    Console.WriteLine("L'aquila");
            //else if (provincia.Equals("Bo"))
            //    Console.WriteLine("Bologna");
            //else
            //    Console.WriteLine("NON TROVATO");
            //----------------------------------------------------------------------------------------


            string provincia = "BO";

            switch (provincia)
            {
                case "AQ":
                    Console.WriteLine("L'Aquila");
                    break;
                case "PE":
                    Console.WriteLine("L'Aquila");
                    break;
                case "BO":
                    Console.WriteLine("L'Aquila");
                    break;
                default:
                    Console.WriteLine("NON TROVATO");
                        break;

            }

        }
    }
}
