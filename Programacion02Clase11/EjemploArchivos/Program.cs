using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Xml.XmlTextReader
            //Framework 4.0

            //ManejadorDeArchivos.Escribir();
            //ManejadorDeArchivos.Leer();

            Persona personaUno = new Persona();
            personaUno.nombre = "Victor";
            personaUno.apellido = "Fries";

            Persona personaDos = new Persona();
            personaDos.nombre = "Bruece";
            personaDos.apellido = "Wayne";

            Persona personaTres = new Persona();
            personaTres.nombre = "Owald";
            personaTres.apellido = "Cobblepot";
           
            ManejadorXml.GuardarPersona(personaUno);

            Aula aulaUno = new Aula();
            aulaUno.nombre = "Verde";
            aulaUno.profesor = personaUno;

            ManejadorXml.GuardarAula(aulaUno);

            List<Persona> listaDePersonas = new List<Persona>();
            listaDePersonas.Add(personaUno);
            listaDePersonas.Add(personaDos);

            ManejadorXml.GuardarListaDePersonas(listaDePersonas);

            

            Console.ReadKey();

        }
    }
}
