using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public abstract class SerHumano
    {
        public string dni;

        public SerHumano()
        { }

        public SerHumano(string dni)
        {
            this.dni = dni;
        }
    }
}
