using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_06_Atrazione.classes
{
    internal abstract class Animale
    {
        public bool HasPelo { get; set; }
        public bool numZampe { get; set; }
        public bool vola { get; set; }


        public abstract void versoEmesso();
        


    }
}
