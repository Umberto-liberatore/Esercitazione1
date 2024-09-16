using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_02_Properies.Classes
{
    internal class Bottiglia
    {

        public string ? MAteriale { get; set; }


        private string? marca;

        //public string?  Marca
        //{
        //	get { return marca; }
        //	set { marca = value; }
        //}
        public string? Marca { get; set; } // metodo corto (GET ,SET)

        private float altezza = 0;

        public float Altezza
        {
            get { return altezza; }
            set
            {
                if (value > 0)
                    altezza = value;
                else
                    Console.WriteLine("Errore di altezza");
            }
        }




        private float diametro = 0;

        public float Diametro
        {
            get { return diametro; }
            set
            {
                if (value > 0)
                    diametro = value;
                else
                    Console.WriteLine("Errore di diametro");
            }
        }


        public float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;
        }





    }
}
