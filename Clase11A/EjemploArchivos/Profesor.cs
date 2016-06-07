using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
   public class Profesor:Persona
    {
        public string materia;

       public Profesor():base()
        { }

       public Profesor(string materia):this()        
       {
           this.materia = materia;
       }

    }
}
