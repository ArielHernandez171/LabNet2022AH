using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPExeptionsMethodsExeptionsUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPExeptionsMethodsExeptionsUnitTest.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void dividirTest()
        {
            Calculadora calculadora = new Calculadora();
            
            float result = calculadora.dividir(5,15);
            Assert.AreEqual(3,result);
        }
        [TestMethod()]
        public void dividirCeroTest()
        {
            Calculadora calculadora = new Calculadora();
            float result=calculadora.dividir(0,15);
            Assert.AreNotEqual(5,result);
        }
    }
}