using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////System.Xml.XmlTextReader
            ////Framework 4.0

            ////ManejadorDeArchivos.Escribir();
            ////ManejadorDeArchivos.Leer();

            Persona personaUno = new Persona();
            personaUno.nombre = "Victor";
            personaUno.apellido = "Fries";
            personaUno.dni = "1111";

            ////Persona personaDos = new Persona();
            ////personaDos.nombre = "Bruece";
            ////personaDos.apellido = "Wayne";
            ////personaDos.dni = "2222";

            ////Persona personaTres = new Persona();
            ////personaTres.nombre = "Owald";
            ////personaTres.apellido = "Cobblepot";
            ////personaTres.dni = "3333";

            ////Persona personaCuatro = new Persona();
            ////personaCuatro.nombre = "James";
            ////personaCuatro.apellido = "Gordon";
            ////personaCuatro.dni = "4444";

            ////ManejadorXml.GuardarPersona(personaUno);

            ////Aula aulaUno = new Aula();
            ////aulaUno.nombre = "Verde";
            ////aulaUno.profesor = personaUno;

            ////ManejadorXml.GuardarAula(aulaUno);

            ////List<Persona> listaDePersonas = new List<Persona>();
            ////listaDePersonas.Add(personaUno);
            ////listaDePersonas.Add(personaDos);

            ////ManejadorXml.GuardarListaDePersonas(listaDePersonas);

            //Profesor profesorUno = new Profesor();
            //profesorUno.nombre = "Bruece";
            //profesorUno.apellido = "Wayne";
            //profesorUno.dni = "2222";

            //Alumno alumnoUno = new Alumno();
            //alumnoUno.nombre = "Victor";
            //alumnoUno.apellido = "Fries";
            //alumnoUno.dni = "1111";

            //Alumno alumnoDos = new Alumno();
            //alumnoDos.nombre = "Owald";
            //alumnoDos.apellido = "Cobblepot";
            //alumnoDos.dni = "3333";

            //Aula aulaDos = new Aula();
            ////aulaDos.nombre = "Roja";
            ////aulaDos.profesor = personaUno;
            ////aulaDos.listaDeAlumnos.Add(personaDos);
            ////aulaDos.listaDeAlumnos.Add(personaTres);
            //aulaDos.listaDePersonas.Add(profesorUno);
            //aulaDos.listaDePersonas.Add(alumnoUno);
            //aulaDos.listaDePersonas.Add(alumnoDos);


            //ManejadorXml.GuardarAulaDos(aulaDos);

            ////Alumno alumnoUno = new Alumno();
            ////alumnoUno.nombre = "Victor";
            ////alumnoUno.apellido = "Fries";
            ////alumnoUno.dni = "1111";

            ////Alumno alumnoDos = new Alumno();
            ////alumnoDos.nombre = "Owald";
            ////alumnoDos.apellido = "Cobblepot";
            ////alumnoDos.dni = "3333";

            ////Profesor profesorUno = new Profesor();
            ////profesorUno.nombre = "Bruece";
            ////profesorUno.apellido = "Wayne";
            ////profesorUno.dni = "2222";

            ////Profesor profesorDos = new Profesor();
            ////profesorDos.nombre = "James";
            ////profesorDos.apellido = "Gordon";
            ////profesorDos.dni = "4444";

            ////Aula aulaTres = new Aula();
            ////aulaTres.nombre = "Azul";
            ////aulaDos.listaDeAlumnos.Add(alumnoUno);
            ////aulaDos.listaDeAlumnos.Add(alumnoDos);
            //////aulaDos.listaDeProfesores.Add(profesorUno);
            //////aulaDos.listaDeProfesores.Add(profesorDos);

            ////ManejadorXml.GuardarAulaDos(aulaTres);

            //Aula miAula;
            //miAula = ManejadorXml.CargarAula();

            Estacionamiento estacionamientoUno = new Estacionamiento();
            estacionamientoUno.dueño = personaUno;

            Auto unAuto = new Auto();
            unAuto.tipoDeMotor = "A";
            unAuto.puertas = 4;

            Moto unaMoto = new Moto();
            unaMoto.tipoDeMotor = "B";
            unaMoto.cilindrada = 150;

            Camioneta unaCamioneta = new Camioneta();
            unaCamioneta.tipoDeMotor = "C";
            unaCamioneta.altura = 1.9f;

            estacionamientoUno.listaDeVeiculos.Add(unAuto);
            estacionamientoUno.listaDeVeiculos.Add(unaMoto);
            estacionamientoUno.listaDeVeiculos.Add(unaCamioneta);
     
            ManejadorXml.GuardarEstacionamiento(estacionamientoUno);

            Console.ReadKey();

        }
    }
}
