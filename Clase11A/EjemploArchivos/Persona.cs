using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
    [XmlInclude(typeof(Alumno))]//asi se incluyen los tipos de clases 
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Dueño))]
   public class Persona:SerHumano,ISerializable
    {
        public string nombre;
        public string apellido;

        public Persona():base()
        { }

        public Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public bool GuardarEnXml()
        {
            return ManejadorXml.GuardarPersona(this);
        }
    }
}
