using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPExeptionsMethodsExeptionsUnitTest
{
    static class IntExtencion
    {
        public static float divide(this int dividendo, int divisor) {

            float result = dividendo / divisor;
            return result;
        }
    }
}
