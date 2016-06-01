using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Aula
    {
        public string nombre;
        public Persona profesor;
        public List<Persona> listaDeAlumnos;

        public Aula()
        {
            this.listaDeAlumnos = new List<Persona>();
        }

        
    }
}
