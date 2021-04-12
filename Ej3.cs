using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1
{
    class Ej3
    {

      

        public void ejercicio3()
        {


            Console.WriteLine("Numero de telefono: ");
            string telefono = Console.ReadLine();

            Console.WriteLine("Mi matricula 2018 - 6753");

            Console.WriteLine("");
            Console.WriteLine("Numeros que contiene");

            for (int i = 0; i < telefono.Length; i++)
            {

           

                if ((telefono[i] == '2')
                    || (telefono[i] == '0')
                    || (telefono[i] == '1')
                    || (telefono[i] == '8')
                    || (telefono[i] == '6')
                    || (telefono[i] == '7')
                    || (telefono[i] == '5')
                    || (telefono[i] == '3')
                    )
                {
                  
                    Console.Write(telefono[i]+ " ");

                }

            }

                Console.ReadKey();
        
        }
    }
}
