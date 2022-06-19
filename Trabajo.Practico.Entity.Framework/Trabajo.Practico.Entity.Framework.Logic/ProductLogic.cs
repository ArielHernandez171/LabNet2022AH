using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Practico.Entity.Framework.Entities;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    public class ProductLogic: ABLMContext
    {
        public bool EsForeignKey(int id)
        {
            bool esta = false;
            List<Products> productsList = context.Products.ToList();
            if (context.Products.Any(p => p.SupplierID == id))
                esta = true;
            return esta;
        }
    }
}
