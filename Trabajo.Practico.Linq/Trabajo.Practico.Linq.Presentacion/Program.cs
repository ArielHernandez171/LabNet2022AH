using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.Practico.Linq.Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentacion presentacion = new Presentacion();
            int opcion;
            int seguir = 0;
            do
            {
                Console.WriteLine("Seleccione el numero del ejercicio, 14 para salir o 15 para limpiar consola");
                opcion = presentacion.IngresarEntero();
                switch (opcion)
                {
                    case 1:
                        presentacion.MostrarObjetoCustomers();
                        break;
                    case 2:
                        presentacion.MostrarProductosSinStock();
                        break;
                    case 3:
                        presentacion.MostrarProductosConStockYMasDeTres();
                        break;
                    case 4:
                        presentacion.MostarCustomersDeWA();
                        break;
                    case 5:
                        presentacion.MostrarPrimerProductoSinStockONulo();
                        break;
                    case 6:
                        presentacion.MostrarNombreDeCustomers();
                        break;
                    case 7:
                        presentacion.MostrarJoinCustomersYOrders();
                        break;
                    case 8:
                        presentacion.MostrarPrimerosTresCustomersDeWA();
                        break;
                    case 9:
                        presentacion.MostarProductosOrdenadosPorNombre();
                        break;
                    case 10:
                        presentacion.MostrarProductosOrdenadosPorUnit();
                        break;
                    case 11:
                        presentacion.MostrarCategoriasAsociadasAProductos();
                        break;
                    case 12:
                        presentacion.MostrarPrimerProducto();
                        break;
                    case 13:
                        presentacion.MostarCustomersConOrdenesAsociadas();
                        break;
                    case 14:
                        seguir++;
                        break;
                    case 15:
                        Console.Clear();
                        break;
                    default:
                        seguir++;
                        break;
                }
            } while (seguir==0);
        }
    }
}
