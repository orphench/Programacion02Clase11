using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
    [XmlInclude(typeof(Motorizados))]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Camioneta))]
   public abstract class Vehiculo
    {
    }
}
