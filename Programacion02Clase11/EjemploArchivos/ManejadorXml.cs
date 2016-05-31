﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    public class ManejadorXml
    {
        public static bool GuardarPersona(Persona personaUno)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    //REGLAS:
                    //CLASE PUBLICA Y CONSTRUCTOR POR DEFECTO

                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, personaUno);
                }
            }
            catch (Exception ex)
            {

                //Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static bool GuardarAula(Aula aulaUno)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml" ,Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aulaUno);
                }
            }
            catch (Exception ex)
            {

                return false;
            }

            return true;
        }

        public static bool GuardarListaDePersonas(List<Persona> listaPersonas)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("ListaPersonas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));
                    serializador.Serialize(escritor, listaPersonas);
                }
            }
            catch (Exception ex)
            {

                return false;
            }

            return true;
        }
    }
}
