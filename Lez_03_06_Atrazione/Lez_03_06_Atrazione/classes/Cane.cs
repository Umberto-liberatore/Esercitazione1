using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_06_Atrazione.classes
{
    internal class Cane: Animale
    {
        public string? Colore { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void versoEmesso()
        {
            Console.WriteLine();
        }
    }
}
