using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea_1
{
    class Ej5
    {
        public void ejercicio5()
        {
            Console.Write("Digite su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Digite su apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Digite su telefono: ");
            string telefono = Console.ReadLine();


            string ruta = "C:\\CREACIONES WEB";
            if (Directory.Exists(ruta) == false)
            {
                Directory.CreateDirectory(ruta);
            }
            


            string contenido = "<html>" +
                "<head>" +
                "<link rel='preconnect' href='https://fonts.gstatic.com'> " +
                "<link href='https://fonts.googleapis.com/css2?family=Spartan:wght@300&display=swap' rel='stylesheet'>   "+
            "</head>" +
                "<body>" +
                " <div>" +
                "<style>" +
                "div { background-color: rgba(240, 248, 255, 0.856); width: 400px; height: 400px; box-shadow: 0 0 16px 0 rgba(0, 0, 0, 0.185);  padding: 80px;border-radius: 100px;   }" +
                "body{font-family: 'Spartan', sans-serif; display: flex; justify-content: center;   align-items: center;  height: 100vh;   background-size: contain;  background - attachment: fixed; background-image: url(https://i.pinimg.com/originals/47/0a/19/470a19a36904fe200610cc1f41eb00d9.jpg); }" +
                "h2 span{ color: rgb(75, 75, 75);}" +
                "  h2{ font-size: 20px; color: rgb(116, 116, 116);}" +
                "</style>" +

                "<h2><span>Nombre: </span> "+nombre+ "</h2>" +
                "<h2><span>Apellido: </span> "+apellido+ "</h2>" +
                "<h2><span>Telefono: </span> "+telefono+ "</h2>" +
                " </div>" +
                "" +
                "" +
                "" +
                "</body>" +
                "</html>";

            File.WriteAllText("C:\\CREACIONES WEB\\" + nombre + ".html", contenido);
            Console.ReadKey();
            Console.WriteLine("Documento Guardado");
        }
    }
}
