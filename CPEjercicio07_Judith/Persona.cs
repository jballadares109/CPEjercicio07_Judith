using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio07_Judith
{
    internal class Persona
    {
        public Persona() { }

        public Persona(string n)
        {
            this.n = n;
        }

        string n;

        public string N { get => n; set => n = value; }
        public virtual string Tostring()
        {
            return N;
        }
    }
}
