using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.Practico.Entity.Framework.Logic.Excepciones
{
    public class ExcepcionEstaVinculada:Exception
    {
        public ExcepcionEstaVinculada(string mensaje) : base(mensaje) { }
       
    }
}
