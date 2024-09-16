using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_02_Composizioni.Classes
{
    internal class Mazzo
    {
        public bool HasFiocco { get; set; } = true;
        public List<Fiore>? Lista {  get; set; }=new List<Fiore>();

        public void AggiungiFiore(Fiore objFio)
        {
            if (Lista == null)

                Lista = new List<Fiore>();

            Lista.Add(objFio);
        }

        public int ContaFiori()
        {
            if (Lista is null)
                return 0;
            return Lista.Count;
        }
    }
}
