using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    

    public class Aula
    {
        public string nombre;
        public Persona profesor;
        //public List<Persona> listaDeAlumnos;
        //public List<Persona> listaDeProfesores;
        public List<Persona> listaDePersonas;

        public Aula()
        {
            //this.listaDeAlumnos = new List<Persona>();
            //this.listaDeProfesores = new List<Persona>();
            this.listaDePersonas = new List<Persona>();
        }

        
    }
}
