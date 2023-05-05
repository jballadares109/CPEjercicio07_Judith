using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio07_Judith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] hum = new Persona[3];

            for (int i = 0; i < 3; i++)
            {
                if(i==0)
                {
                    hum[i] = new Profesor(Console.ReadLine());
                }
                else
                {
                    hum[i]=new Estudiante(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if(i==0)
                {
                    ((Profesor)hum[i]).Explicar();
                }
                else
                {
                    ((Estudiante)hum[i]).Estudiar();
                }
            }
            Console.ReadKey();
        }
    }
}
