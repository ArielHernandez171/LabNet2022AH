using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Practico.Entity.Framework.Data;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    public abstract class ABLMContext
    {
        protected readonly NorthWindContext context;
        
        public ABLMContext()
        {
            context = new NorthWindContext();
        }
    }
}
