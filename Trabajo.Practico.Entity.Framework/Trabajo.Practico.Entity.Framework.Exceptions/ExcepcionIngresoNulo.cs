using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.Practico.Entity.Framework.Exceptions
{
    public class ExcepcionIngresoNulo:Exception
    {
        public ExcepcionIngresoNulo(string message) : base(message) { }
        public ExcepcionIngresoNulo() : base("Error en el ingreso de datos"){ }
    }
}
