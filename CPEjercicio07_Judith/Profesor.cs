using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio07_Judith
{
    internal class Profesor : Persona
    {
        public Profesor(string n)
        {
            this.N = n;
        }
        public void Explicar()
        {
            Console.WriteLine("Explicar.");
        }
    }
}
