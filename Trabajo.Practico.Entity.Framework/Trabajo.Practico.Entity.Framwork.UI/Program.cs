using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Logic;

namespace Trabajo.Practico.Entity.Framwork.UI
{
    internal class Program
    {
        private static void MostrarSupplier(List<Suppliers> suppliers)
        {
            foreach (var supplier in suppliers)
            {
                Console.WriteLine("ID:" + supplier.SupplierID +
                                  " Nombre de la compania:" + supplier.CompanyName +
                                  " Contacto:" + supplier.ContactName +
                                  " Titulo de contacto:" + supplier.ContactTitle +
                                  " Direccion:" + supplier.Address +
                                  " Ciudad:" + supplier.City +
                                  " Region:" + supplier.Region +
                                  " CP:" + supplier.PostalCode +
                                  " Pais:" + supplier.Country +
                                  " Telefono:" + supplier.Phone +
                                  " Fax:" + supplier.Fax +
                                  " HomePage:" + supplier.HomePage);
            }
        }
        private static void MostrarShippers(List<Shippers> shippers)
        {
            foreach (var shipper in shippers)
            {
                Console.WriteLine("ID:" + shipper.ShipperID +
                                  " Telefono" + shipper.Phone +
                                  " Nombre de la compania" + shipper.CompanyName);
            }
        }
        static void Main(string[] args)
        {
            int seguir = 0;
            int opcion = 0;
            IngresoDeParametros ingreso = new IngresoDeParametros();
            SuppiersLogic suppliers = new SuppiersLogic();
            ShippersABLM shippersABLM = new ShippersABLM();
            
            do
            {
                Console.WriteLine("Listar Suppliers:1");
                Console.WriteLine("Listar Shippers:2");
                Console.WriteLine("Crear Shippiers:3");
                Console.WriteLine("Crear Suppliers:4");
                Console.WriteLine("Eliminar Shippiers:5");
                Console.WriteLine("Eliminar Supplers:6");
                Console.WriteLine("Modificar Suppler:7");
                Console.WriteLine("Modificar Shippier:8");
                Console.WriteLine("Salir:9");
                Console.WriteLine("Limpiar pantalla:10");
                opcion = ingreso.IngresarEntero();
                switch (opcion)
                {
                    case 1:
                        MostrarSupplier(suppliers.GetAll());
                        break;
                    case 2:
                        MostrarShippers(shippersABLM.GetAll());
                        break;
                    case 3:
                        ingreso.CrearShippers();
                        break;
                    case 4:
                        ingreso.CrearSuppliers();
                        break;
                    case 5:
                        ingreso.EliminarShipper();
                        break;
                    case 6:
                        ingreso.EliminarSuppler();
                        break;
                    case 7:
                        ingreso.ModficarSuppler();
                        break;
                    case 8:
                        ingreso.ModficarSuppler();
                        break;
                    case 9:
                        seguir++;
                        break;
                    case 10:
                        Console.Clear();
                        break;
                }
            } while (seguir==0);
        }
       
    }
}
