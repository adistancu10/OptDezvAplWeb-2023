using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class Student
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Varsta { get; set; }

        public string CNP { get; set; }


        public List<Materie> Materii { get; set; }

        public Student(string nume, string prenume, string varsta, string cnp)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            CNP =  cnp; 
            Materii = new List<Materie>();
        }

        public void AdaugareMaterie(string titlu, string durata)
        {
            Materii.Add(new Materie(titlu, durata));
        }
    }
}
