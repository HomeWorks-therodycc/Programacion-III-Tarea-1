using System;

namespace Tarea_1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ejercicio   [1]");
            Console.WriteLine("Ejercicio   [2]");
            Console.WriteLine("Ejercicio   [3]");
            Console.WriteLine("Ejercicio   [4]");
            Console.WriteLine("Ejercicio   [5]");
            Console.WriteLine("Ejercicio   [6]");
            Console.WriteLine("Ejercicio   [7]");

            Console.WriteLine("Cual desea elegir?");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Ej1 ejer1 = new Ej1();
                    ejer1.ejercicio1();
                    break; 
                    
                case 2:
                    Console.Clear();
                    Ej2 ejer2 = new Ej2();
                    ejer2.Ejercicio2();
                break; 

                case 3:
                    Console.Clear();
                    Ej3 ejer3 = new Ej3();
                    ejer3.ejercicio3();
                break;

                case 4:
                    Console.Clear();
                    Ej4 ejer4 = new Ej4();
                    ejer4.ejercicio4();
                    break;

                case 5:
                    Console.Clear();
                    Ej5 ejer5 = new Ej5();
                    ejer5.ejercicio5();
                    break;

                case 6:
                    Console.Clear();
                    Ej6 ejer6 = new Ej6();
                    ejer6.ejercicio6();
                    break;

                case 7:
                    Console.Clear();
                    Ej7 ejer7 = new Ej7();
                    ejer7.ejercicio7();
                    break;

                default:
                    Console.WriteLine("Digite su opcion correctamente");
                    
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Main(args);

        }
    }
}
