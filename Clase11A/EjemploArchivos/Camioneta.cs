using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Camioneta:Motorizados
    {
       public string altura;

       public Camioneta():base()
       { }

        public Camioneta(string altura, string motor):this()
        {
            this.altura = altura;
            this.tipoDeMotor = motor;
        }
    }
}
