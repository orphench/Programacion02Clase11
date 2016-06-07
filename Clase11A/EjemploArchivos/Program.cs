using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

//frameword 4.0


namespace EjemploArchivos
{
   public class Program
    {
        static void Main(string[] args)
        {
            Persona perUno = new Persona();
            perUno.apellido = "rodriguezzzzz";
            perUno.nombre = "carlitos";

          //  ManejadorXml.GuardarPersona(perUno);

          //  Aula aulaUno = new Aula();
          ///*  aulaUno.profesor.apellido = "chololo";
          //  aulaUno.profesor.nombre = "montoto";*/
          //  aulaUno.nombre = "aula666";
          //  aulaUno.profesor = perUno;

          //  ManejadorXml.GuardarAula(aulaUno);

            Persona perDos = new Persona();
            perDos.apellido = "benito";
            perDos.nombre = "pandolfa";
            perDos.dni = "38.123.123";
            perUno.dni = "12.123.124";

          //  List<Persona> listado = new List<Persona>();
          //  listado.Add(perUno);
          //  listado.Add(perDos);

          //  ManejadorXml.GuardarListaPersonas(listado);

          //  aulaUno.listadoDeAlumnos = listado;

          //  ManejadorXml.GuardarAula(aulaUno);

          //  Aula nuevaAula = new Aula();

          //  Alumno alumnoUno = new Alumno("4321");
          //  Alumno alumnoDos = new Alumno("76547");

          //  Profesor profesorUno = new Profesor("Matematica");

          //  alumnoUno.nombre = "ricarda";
          //  alumnoUno.apellido = "espindola";
          //  alumnoUno.dni = "12.234.567";

          //  alumnoDos.nombre = "Patricia";
          //  alumnoDos.apellido = "Del Monte";
          //  alumnoDos.dni = "54.345.654";

          //  profesorUno.nombre = "jusepe";
          //  profesorUno.apellido = "trotamundo";
          //  profesorUno.dni = "3.123.987";

          //  nuevaAula.listadoDeAlumnos.Add(alumnoUno);
          //  nuevaAula.listadoDeAlumnos.Add(alumnoDos);
          //  nuevaAula.profesor = profesorUno;
          //  nuevaAula.nombre = "Aula 312";
            

          //  ManejadorXml.GuardarAula(nuevaAula);

            Aula miAula ;

            miAula = ManejadorXml.CargarAula();

            //ESTACIONAMIENTO

            Estacionamiento miEstacionamiento = new Estacionamiento();

            Dueño dueñoUno = new Dueño("123", "12/9/86", "roberto", "manchini", "2,123,123");

            miEstacionamiento.elDueño = dueñoUno;
            Moto motoUno = new Moto("120 cc", "120");
            Auto autoUno = new Auto("5", "1.6");
            Camioneta camionetaUno = new Camioneta("2.0", "3.0");
            miEstacionamiento.listaDeVehiculos.Add(motoUno);
            miEstacionamiento.listaDeVehiculos.Add(autoUno);
            miEstacionamiento.listaDeVehiculos.Add(camionetaUno);

            //ManejadorXml.GuardarEstacionamiento(miEstacionamiento);
            miEstacionamiento.GuardarEnXml();
           
            Estacionamiento CargarEst;

            BackUp.HacerBackUp(perUno);

            CargarEst = ManejadorXml.CargarEstacionamiento();
            // System.Xml.XmlTextReader

            List<ISerializable> listaISerializable = new List<ISerializable>();
            listaISerializable.Add(miEstacionamiento);
            listaISerializable.Add(miAula);
            listaISerializable.Add(perDos);

            foreach (ISerializable item in listaISerializable)
            {
                BackUp.HacerBackUp(item);
            }
        }
    }
}
