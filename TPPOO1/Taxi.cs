using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPOO1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }
        public override string obtenerTipoTransporte()
        {
            return "Taxi:";
        }
        public override string avanzar()
        {
            return "Esta avanzando";
        }

        public override string detenerse()
        {
            return "Se detuvo";
        }
    }
}
