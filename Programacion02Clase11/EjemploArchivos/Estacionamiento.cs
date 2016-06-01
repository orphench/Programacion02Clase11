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

    public class Estacionamiento
    {
        public Persona dueño;
        public List<Vehiculo> listaDeVeiculos;

        public Estacionamiento()
        {
            this.listaDeVeiculos = new List<Vehiculo>();
        }
    }
}
