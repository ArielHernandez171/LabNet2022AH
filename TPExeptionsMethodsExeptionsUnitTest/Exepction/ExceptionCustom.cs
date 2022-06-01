using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPExeptionsMethodsExeptionsUnitTest.Exepction
{
    public class ExceptionCustom: Exception
    {
        public ExceptionCustom(string massage) : base(massage)
        {

        }
        public ExceptionCustom() : base("Una exepcion custom") { }
    }
}
