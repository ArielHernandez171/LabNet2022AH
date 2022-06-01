using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPExeptionsMethodsExeptionsUnitTest.Exepction;

namespace TPExeptionsMethodsExeptionsUnitTest
{
    internal class Program
    {
        
        public static int leerOpcion()
        {
            int opcion = 0;
            try
            {
                opcion = int.Parse(Console.ReadLine());
                
                return opcion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return opcion;
        }
        
        static void Main(string[] args)
        {
            int Opciones = 0;
            int Seguir = 0;
            int divisor = 0;
            int dividendo = 0;
            Calculadora calculadora = new Calculadora();
            do
            {
                Console.WriteLine("1: Intentar dividir 15 entre 0");
                Console.WriteLine("2: Divicion con excepcion");
                Console.WriteLine("3: Excepcion normal");
                Console.WriteLine("4: Excepcion custom");
                Console.WriteLine("5: Salir");
                Opciones = leerOpcion();
                switch (Opciones)
                {
                    case 1:
                        calculadora.dividirPorCero(0,15);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el divisor");
                        divisor = leerOpcion();
                        Console.WriteLine("Ingresar el dividendo");
                        dividendo = leerOpcion();
                        calculadora.dividir(divisor,dividendo);
                        break;
                    case 3:
                        calculadora.excepcionNormal();
                        break;
                    case 4:
                        calculadora.excepcionPersonalizada();
                        break;
                    case 5:
                        Seguir = 1;
                        break;
                    default:
                        Seguir = 1;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (Seguir == 0);

        }
    }
}
