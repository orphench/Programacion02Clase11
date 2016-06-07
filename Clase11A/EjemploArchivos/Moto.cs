using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
   public class Moto:Motorizados
    {
       public string cilindrada;

        public Moto():base()
        { }
        public Moto(string cc, string motor):this()            
        {
            this.cilindrada = cc;
            this.tipoDeMotor = motor;
        }

    }
}
