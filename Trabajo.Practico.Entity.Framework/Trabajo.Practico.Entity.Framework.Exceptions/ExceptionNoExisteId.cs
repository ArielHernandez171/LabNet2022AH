using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.Practico.Entity.Framework.Exceptions
{
    public class ExcepcionNoExisteId : Exception
    {
        public ExcepcionNoExisteId() : base("No se encontro ningun elemento con este ID")
        {

        }
        public ExcepcionNoExisteId(string mensaje) : base(mensaje)
        {

        }
    }
}
