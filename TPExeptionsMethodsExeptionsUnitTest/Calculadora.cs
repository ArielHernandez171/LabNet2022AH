using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPExeptionsMethodsExeptionsUnitTest.Exepction;

namespace TPExeptionsMethodsExeptionsUnitTest
{
    public class Calculadora
    {
        public Calculadora()
        {

        }
        public float dividir(int divisor, int dividendo)
        {
            float result=0;
            try
            {
               
                result = dividendo.divide(divisor);
                Console.WriteLine("El resultado es:{0}",result);
                 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo THE CHOSEN ONE puede dividir por 0");
                Console.WriteLine(ex.Message);
            }
            return result;
            
        }
        public void excepcionNormal()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public void excepcionPersonalizada()
        {
            try
            {
                throw new ExceptionCustom("Excepcion personalizada");
            }
            catch(ExceptionCustom ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public void dividirPorCero(int divisor,int dividendo)
        {
            float result;
            try
            {
                result = dividendo / divisor;
                Console.WriteLine("{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("La operacion fracaso");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La operacion termino");
            }
        }
    }
}
