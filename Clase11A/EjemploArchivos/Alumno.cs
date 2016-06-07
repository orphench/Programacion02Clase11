using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
   public class Alumno:Persona
    {
        public string legajo;

        public Alumno():base()
        { }
        public Alumno(string legajo):this()            
        {
            this.legajo = legajo;
        }

    }
}
