using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class BackUp
    {
        public static bool HacerBackUp(ISerializable parametro)
        {
            return parametro.GuardarEnXml();

        }
    }
}
