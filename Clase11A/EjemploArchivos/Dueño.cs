using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
   public class Dueño:Persona
    {
       public string cuit;
       public string fechaDeInscripcion;

       public Dueño():base()
       { }

       public Dueño(string cuit, string Fecha,string nombre, string apellido, string dni):this()
       {
           this.apellido = apellido;
           this.cuit = cuit;
           this.dni = dni;
           this.fechaDeInscripcion = Fecha;
           this.nombre = nombre;
       }


    }
}
