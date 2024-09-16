using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_01_RecapClassi
{
    internal class Bottiglia
    {
        private string? materiale;
        private string? colore;
        private float diametro = 0;
        private float altezza = 0;
        private string? contenuto;

        public void SetAltezza(float varAltezza)
        {
            if (varAltezza > 0)
                this.altezza = varAltezza;

        }

        public float GetAltezza()
        {
            return this.altezza;
        }


        public void SetDiametro(float varDiametro)
        {
            if (varDiametro > 0)
                this.diametro = varDiametro;

        }
        public void GetDiametro(float varDiametro)
        {
            if (varDiametro > 0)
                this.diametro = varDiametro;
        }



        public float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area*altezza;
        }
    
        public void DettaglioGeometria()
        {
            Console.WriteLine($" La bottiglia ha questi dati:\n" +
                $"Altezza: {altezza}\n" +
                $"Diametro: {diametro}\n" +
                $"Volume: {CalcolaVolume()}");
        }
    
    }
}
