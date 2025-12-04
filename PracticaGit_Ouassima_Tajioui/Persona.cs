using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGit_Ouassima_Tajioui
{
    class Persona
    {
        public string Nom { get; set; }
        public int Edat { get; set; }
        public Persona(string nom, int edat)
        {
            Nom = nom;
            Edat = edat;
        }
    }
}
