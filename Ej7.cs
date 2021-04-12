using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1
{
    class Ej7
    {
        public void ejercicio7()
        {
         
                Console.WriteLine("Ingrese su calificacion: ");
                string notaentrada = Console.ReadLine();
            int nota = int.Parse(notaentrada);

            if (nota > 100)
            {
                Console.WriteLine("Debe digitar una nota menor o igual a 100");
                Console.ReadKey();
                Console.Clear();
                ejercicio7();
            }
            else
            {
                string Resultado = "";



                Random num = new Random();
                int Num1 = num.Next(0, 35);
                int Num2 = num.Next(0, 35);
                int Num3 = num.Next(0, 30);

                while (Num1 + Num2 + Num3 != nota)
                {
                    Num1 = num.Next(1, 35);
                    Num2 = num.Next(1, 35);
                    Num3 = num.Next(1, 30);
                }


                if (nota >= 90 && nota <= 100)
                {
                    Resultado = "Su calificacion es A";
                }
                else if (nota >= 80 && nota < 90)
                {
                    Resultado = "Su calificacion es B";
                }
                else if (nota >= 70 && nota < 80)
                {
                    Resultado = "Su calificacion es C";
                }
                else if (nota < 70)
                {
                    Resultado = "Reprobado";
                }


                Console.WriteLine("-- " + Num1);
                Console.WriteLine("-- " + Num2);
                Console.WriteLine("-- " + Num3);
                Console.WriteLine(Resultado);
                Console.ReadKey();
            }
        }
    }
    
}
