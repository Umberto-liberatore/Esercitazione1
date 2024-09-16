namespace Lez02_04_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gio = { "Giovanni", "Pace", "ABC1234" };
            string[] val = { "Valeria", "Verdi Verdoni", "ABC1234" };
            string[] mar = { "Mario", "Rossi", "ABC1234" };

            List<string[]>elenco = new List<string[]>();
            elenco.Add (gio);
            elenco.Add(val);
            elenco.Add(mar);

            //for (int i = 0; i < elenco.Count; i++) 
            //{
            //    Console.WriteLine($" {elenco [i][0]} {elenco[i][1]} {elenco[i][2]}");

            //}

            for (int i = 0; i < elenco.Count; i++)
            {
                for (int k = 0; k < elenco[i].Length; k++)
                {
                    Console.WriteLine(elenco[i][k]);
                }

            }

        }
    }
}
