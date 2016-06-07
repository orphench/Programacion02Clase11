using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
   public abstract class SerHumano
    {
       public string dni;

       public SerHumano()
       { }

       public SerHumano(string dni):this()
       {
           this.dni = dni;
       }
    }
}
