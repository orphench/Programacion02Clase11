using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    //[XmlInclude(typeof(Auto))]
    //[XmlInclude(typeof(Moto))]
    //[XmlInclude(typeof(Camioneta))]

    public class Motorizados: Vehiculo
    {
        public string tipoDeMotor;

        public Motorizados()
        { }
    }
}
