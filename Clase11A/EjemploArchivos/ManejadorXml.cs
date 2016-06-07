using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
    class ManejadorXml
    {
        public static bool GuardarPersona(Persona per)
        {
           
            try
            {
                using (XmlTextWriter ejemplo = new XmlTextWriter("persona.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));//crear el serializador con la clase persona
                    serializador.Serialize(ejemplo, per);
                }
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }

        public static bool GuardarAula(Aula miAlula)
        {

            try
            {
                using (XmlTextWriter ejemplo = new XmlTextWriter("aula.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));//crear el serializador con la clase persona
                    serializador.Serialize(ejemplo, miAlula);
                }
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }
        public static bool GuardarListaPersonas(List<Persona> per)
        {

            try
            {
                using (XmlTextWriter ejemplo = new XmlTextWriter("listadoDePersonas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));//crear el serializador con la clase persona
                    serializador.Serialize(ejemplo, per);
                }
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }

        public static Aula CargarAula()
        {
            Aula aulaAux;
            try
            {
                using (XmlTextReader lector = new XmlTextReader("aula.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    aulaAux= (Aula)serializador.Deserialize(lector);
                }
            }
            catch (Exception)
            {
                return null;
               // throw;
            }

            return aulaAux;
        }

        public static bool GuardarEstacionamiento(Estacionamiento miEsta)
        {
            try
            {
                using (XmlTextWriter guardar = new XmlTextWriter("Estacionamiento.xml",Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Estacionamiento));
                    serializador.Serialize(guardar, miEsta);
                }
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
            return true;
        }
        public static Estacionamiento CargarEstacionamiento()
        {
            Estacionamiento EstAux;
            try
            {
                using (XmlTextReader lector = new XmlTextReader("Estacionamiento.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Estacionamiento));
                    EstAux = (Estacionamiento)serializador.Deserialize(lector);
                }
            }
            catch (Exception)
            {
                return null;
                // throw;
            }

            return EstAux;
        }

    }
}
