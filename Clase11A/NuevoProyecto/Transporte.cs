using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Transporte
    {
        public int capacidadEnCajones;
        public List<Cajon> listaDecajon;

        public Transporte()
        { }

        public abstract bool tieneMotor
        {
            get;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }
}
