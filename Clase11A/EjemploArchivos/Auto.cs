using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
   public class Auto:Motorizados
    {
       public string puertas;

        public Auto() :base()
        { }

        public Auto(string puertas,string motor):this()           
        {
            this.puertas = puertas;
            this.tipoDeMotor = motor;
        }

    }
}
