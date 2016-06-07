using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
   /* [XmlInclude(typeof(Alumno))]//asi se incluyen los tipos de clases 
    [XmlInclude(typeof(Profesor))]*/
  
    public class Aula:ISerializable
    {
        public string nombre;
        public Persona profesor;
        public List<Persona> listadoDeAlumnos;
       
        public Aula()
        {
            this.listadoDeAlumnos = new List<Persona>();
         }

        public Aula(string nombrePer, string apellidoPer, string nombreAula):this()           
        {
            this.profesor.nombre = nombrePer;
            this.profesor.apellido = apellidoPer;
            this.nombre = nombreAula;
        }

        public bool GuardarEnXml()
        {
            return ManejadorXml.GuardarAula(this);
        }
        

    }
}
