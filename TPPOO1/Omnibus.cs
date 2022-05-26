using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPOO1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }
        public override string obtenerTipoTransporte()
        {
            return "Omnibus:";
        }
        public override string avanzar()
        {
            return "Avanza";
        }

        public override string detenerse()
        {
            return "Se detiene";
        }
    }
}
