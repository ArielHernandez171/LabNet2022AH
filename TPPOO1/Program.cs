using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPOO1
{
    internal class Program
    {
        static void addTransport(List<TransportePublico>transportes)
        {
            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine("Ingrese la cantidad de pasajeros del omnibus");
                    aux = int.Parse(Console.ReadLine());
                    Omnibus transporte = new Omnibus(aux);
                    transportes.Add(transporte);
                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad de pasajeros del taxi");
                    aux = int.Parse(Console.ReadLine());
                    Taxi transporte = new Taxi(aux);
                    transportes.Add(transporte);

                }
            }
            Console.Clear();
        }
        static void showTrasport(List<TransportePublico>transportes)
        {
            foreach (TransportePublico transporte in transportes)
            {
                Console.WriteLine(transporte.obtenerTipoTransporte() + " " + transporte.Getpasajeros);

            }
            Console.ReadKey();
            Console.Clear();

        }
        static void Main(string[] args)
        {   
            int choose = 0;
            List<TransportePublico> transportesList = new List<TransportePublico>();
            int outProgram = 0;
            do {        
                Console.WriteLine("Opcion 1: Mostrar transportes");
                Console.WriteLine("Opcion 2: Agregar 5 taxis y 5 omnubus");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        if (transportesList.Count > 6)
                        {
                            showTrasport(transportesList);
                        }
                        else
                        {
                            Console.WriteLine("Antes de querer mostrar sume transportes a la lista");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        addTransport(transportesList);
                        break;
                }
                Console.WriteLine("Ingrese 0 para salir u otro numero para continuar");
                outProgram = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (outProgram!=0);
        }
    }
}
