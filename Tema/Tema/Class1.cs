using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class Materie
    {
        public string Titlu { get; set; }

        public string Durata { get; set; }

        public Materie(string titlu, string durata)
        {
            Titlu = titlu;
            Durata = durata;
        }
    }
}
