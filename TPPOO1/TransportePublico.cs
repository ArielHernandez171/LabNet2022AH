using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPOO1
{
    public abstract class TransportePublico
    {
        private int pasajeros1;

        public int Getpasajeros => pasajeros1;

        public void Setpasajeros(int value)
        {
            pasajeros1 = value;
        }

        public TransportePublico(int pasajeros)
        {
            this.Setpasajeros(pasajeros);
        }
        public abstract string obtenerTipoTransporte();
        public abstract string avanzar();
        public abstract string detenerse();

    }
}
