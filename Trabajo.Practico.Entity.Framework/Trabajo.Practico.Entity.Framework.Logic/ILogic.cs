using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.Practico.Entity.Framework.Logic
{
    interface ILogic <T>
    {
        List<T> GetAll();
        bool Add(T data);
        bool Udate(T data);
        void Delete(int index);
        T GetOne(int index);
    }
}
