using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Programacion02Clase11
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejadorDeArchivos.Escribir();
            ManejadorDeArchivos.Leer();

            Persona personaUno = new Persona();

            try
            {
                //using ()
                //{
                //    XmlWriter xml = new XmlWriter();
                //}
            }
            catch (Exception)
            {
                
                throw;
            }

            Console.ReadKey();
        }
    }
}
