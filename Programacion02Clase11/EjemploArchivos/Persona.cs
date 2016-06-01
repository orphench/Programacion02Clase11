using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Alumno))]

    public class Persona:SerHumano
    {
        public string nombre;
        public string apellido;
        //public List<Alumno> listaAlumnos;
        //public List<Profesor> listaProfesores;

        public Persona()
        { 

        }   
        
    }
}
