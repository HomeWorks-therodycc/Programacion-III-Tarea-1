using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1
{
    class Ej4
    {
        public void ejercicio4()
        {
            double A, B, C;

            Console.WriteLine("Tipo de triangulo segun sus lados ");
            Console.Write("Parte A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Parte B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Parte C: ");
            C = Convert.ToDouble(Console.ReadLine());

            if (A == B && A == C)
            {
                Console.WriteLine("Es un Triangulo Equilatero");
            }
            else if (A == B || A == C || C == B)
            {
                Console.WriteLine("Es un Triangulo Isosceles");
            }
            else if (A != B || B != C || C != A)
            {
                Console.WriteLine("Es un Triangulo Escaleno");
            }

            Console.ReadKey();
        }
    }
}
