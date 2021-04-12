using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HtmlAgilityPack;



namespace Tarea_1
{
    class Ej6
    {
        public void ejercicio6()
        {
            Console.WriteLine("Link de su sitio web");
            string link = Console.ReadLine();

            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(link);
            int CantP = doc.DocumentNode.Descendants("p").Count();
            int CantImg = doc.DocumentNode.Descendants("img").Count();

            Console.WriteLine("----" + CantP + " Parrafos");
            Console.WriteLine("----" + CantImg + " imgs");
            Console.ReadKey();
        }
    }
}
