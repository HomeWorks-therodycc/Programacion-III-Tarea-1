using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1
{
    class Ej1
    {
        /*Programa que acepte una frase u oración, 
       luego muestre la cantidad de vocales,
       espacios y consonantes que tiene la misma.*/

        public void ejercicio1()
        {
            int vocal = 0;
            int consonante = 0;
            int espacio = 0;
            string frase;

            Console.WriteLine("Digite una frase ");
            frase = Console.ReadLine().ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                if ((frase[i] == ' '))
                {
                    espacio++;
                }
                else if ((frase[i] == 'a') || (frase[i] == 'e') || (frase[i] == 'i') || (frase[i] == 'o') || (frase[i] == 'u'))
                {
                    vocal++;
                }
                else { consonante++; }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hay " + consonante + " Consonantes");
            Console.WriteLine("Hay " + vocal + " Vocales");
            Console.WriteLine("Hay " + espacio + " Espacios");
            Console.WriteLine("");



        }
    }
}
