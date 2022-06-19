using System.Collections.Generic;
using System.Linq;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Exceptions;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    public class SuppiersLogic : ABLMContext, ILogic<Suppliers>
    {
        public SuppiersLogic() : base() { }
        
        public bool Add(Suppliers suppliers)
        {
            context.Suppliers.Add(suppliers);
            context.SaveChanges();
            return true;
        }

        public void Delete(int index)
        {
            ProductLogic productLogic = new ProductLogic();
            if (productLogic.EsForeignKey(index)==true) {
                var suppliers = context.Suppliers.Find(index);
                context.Suppliers.Remove(suppliers);
                context.SaveChanges();
            }
            else
            {
                throw new ExcepcionEstaVinculada("No se puede eliminar este elemento dada su vinculacion");
            }
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public bool Udate(Suppliers suppliers)
        {
            
            var supliersChange = context.Suppliers.Find(suppliers.SupplierID);
            supliersChange.CompanyName = suppliers.CompanyName;
            context.SaveChanges();
            return true;
        }
        public Suppliers GetOne(int id)
        {
            Suppliers suppliers = new Suppliers();
            
            if (context.Suppliers.First(s=>s.SupplierID==id)!=null)
            {
                suppliers =context.Suppliers.First(s=>s.SupplierID==id);
            }else
                throw new ExcepcionNoExisteId();
            return suppliers;
        }
    }
}
