using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1
{

    /*Programa que se ejecute y presionando
     * enter muestre tus datos de contacto:
     * matricula, nombre, apellido, telefono
     * y correo */
    class Ej2
    {
      public void Ejercicio2()
        {
            string nombre = "Rody";
            string Apellido = "Castro Cuello";
            string Matricula = "2018-6753";
            string Correo = "therodycc@gmail.com";
            string Telefono = "829-203-4247";

            Console.WriteLine("Presione enter para ver sus datos");
            Console.ReadKey();

            Console.WriteLine("Nombre: " + nombre );
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("Telefono: " + Telefono);
        }


    }
}
