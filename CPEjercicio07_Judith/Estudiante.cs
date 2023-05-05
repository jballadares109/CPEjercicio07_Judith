using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio07_Judith
{
    internal class Estudiante : Persona
    {
        public Estudiante(string n) 
        {
            this.N = n;
        }
        public void Estudiar()
        {
            Console.WriteLine("Estudiar.");
        }
    }
}
