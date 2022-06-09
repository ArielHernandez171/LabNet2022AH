using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.Practico.Entity.Framework.Entities;
using Trabajo.Practico.Entity.Framework.Logic;
using Trabajo.Practico.Entity.Framework.Logic.Excepciones;

namespace Trabajo.Practico.Entity.Framwork.UI
{
    internal class IngresoDeParametros
    {
        public int IngresarEntero()
        {
            try
            {
                int entero = int.Parse(Console.ReadLine());
                return entero;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                IngresarEntero();
            }
            return 0;
        }
        public void CrearSuppliers()
        {
            Suppliers suppliers = new Suppliers();
            SuppiersLogic suppiersLogic = new SuppiersLogic();
            Console.WriteLine("Ingrese el nombre");
            suppliers.CompanyName = Console.ReadLine();
            suppliers.SupplierID = suppiersLogic.GetAll().Count + 1;
            suppiersLogic.Add(suppliers);//Que sean los not null asi no estan media hs ingresando datos
        }
        public void CrearShippers()
        {
            Shippers shippers = new Shippers();
            ShippersABLM shipperLogic = new ShippersABLM();
            shippers.ShipperID = shipperLogic.GetAll().Count + 1;
            Console.WriteLine("Ingrese el telefono:");
            shippers.Phone=Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la compania");
            shippers.CompanyName = Console.ReadLine();

            shipperLogic.Add(shippers);
        }
        public void EliminarShipper()
        {
            Console.WriteLine("Ingrese el id del shipper a eliminar");
            ShippersABLM shippers = new ShippersABLM();
            int id = this.IngresarEntero();
            try
            {
                shippers.Delete(id);
                Console.WriteLine("Se elimino con exito");
            }
            catch(ExcepcionNoExisteId ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void EliminarSuppler()
        {
            Console.WriteLine("Ingrese el id del suppler a eliminar");
            int id = this.IngresarEntero();
            SuppiersLogic suppiersLogic = new SuppiersLogic();
            try
            {
                suppiersLogic.Delete(id);
                Console.WriteLine("Se elimino con exito");
            }catch(ExcepcionNoExisteId ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ModficarSuppler()
        {
            SuppiersLogic suppiersLogic = new SuppiersLogic();
            Console.WriteLine("Ingrese el id del suppier a modificar");
            int id = this.IngresarEntero();
            Suppliers suppliers = new Suppliers();
            try
            {
                suppliers = suppiersLogic.GetOne(id);
                Console.WriteLine("Escribi el nuevo nombre:");
                suppliers.CompanyName = Console.ReadLine();
                suppiersLogic.Udate(suppliers);
            }
            catch (ExcepcionNoExisteId ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ModificarShipper()
        {
            ShippersABLM shippers = new ShippersABLM();
            Console.WriteLine("Ingrese el id del shipper a modificar");
            int id = this.IngresarEntero();
            try
            {
                var shipper = shippers.GetOne(id);
                Console.WriteLine("Ingrese el nuevo nombre");
                shipper.CompanyName = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo telefono");
                shipper.Phone = Console.ReadLine();
                shippers.Udate(shipper);
            }
            catch (ExcepcionNoExisteId ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
