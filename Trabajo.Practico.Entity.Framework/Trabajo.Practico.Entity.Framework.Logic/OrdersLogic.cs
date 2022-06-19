using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Practico.Entity.Framework.Entities;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    public class OrdersLogic: ABLMContext//Esta clase esta asi, porque solo me interesa que haga esto, en otro contexto deberia tener la ILogic
    {
        public bool EsForgeinKey(int id)
        {
            bool esta=false;
            if (context.Orders.Any(o => o.ShipVia == id))
            {
                esta = true;
            }
            return esta;
        }
    }
}
