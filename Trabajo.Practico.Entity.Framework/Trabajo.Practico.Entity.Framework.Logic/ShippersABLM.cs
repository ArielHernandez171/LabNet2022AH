using System.Collections.Generic;
using System.Linq;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Exceptions;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    public class ShippersABLM : ABLMContext, ILogic<Shippers>
    {
        public ShippersABLM() :base(){ }
        public bool Add(Shippers shippers)
        {
            context.Shippers.Add(shippers);
            context.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            OrdersLogic ordersLogic = new OrdersLogic();
            if (ordersLogic.EsForgeinKey(id)) {
                var shippers = context.Shippers.Find(id);
                context.Shippers.Remove(shippers);
                context.SaveChanges();
            }
            else
            {
                throw new ExcepcionEstaVinculada("No se puede eliminar por su vinculacion con otras tablas");
            }
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public bool Udate(Shippers shippers)
        {
            
            var shippersChange = context.Shippers.Find(shippers.ShipperID);
            shippersChange.Phone = shippers.Phone;
            shippersChange.CompanyName = shippers.CompanyName;
            context.SaveChanges();
            return true;
        }
        public Shippers GetOne(int id)
        {
            Shippers shippers =new Shippers();
            if (context.Shippers.First(s => s.ShipperID.Equals(id)) != null)
            {
                shippers = context.Shippers.First(s => s.ShipperID==id);
            }else
                throw new ExcepcionNoExisteId();
            return shippers;
        }
    }
}
