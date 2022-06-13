using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranbajo.Practico.Linq.Data;

namespace Trabajo.Practico.Linq.Presentacion
{
    internal class Presentacion
    {
        public int IngresarEntero()
        {
            try
            {
                Console.WriteLine("Dijite el Numero");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IngresarEntero();
            }
            return 0;
        }
        public void MostrarObjetoCustomers()
        {
            CostumersQuery customersQuerys = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = customersQuerys.ObtenerCustomers(context);
            foreach (var list in lista)
            {
                Console.WriteLine(list.CustomerID+" "
                    +list.Address+" "
                    +list.City+" "
                    +list.CompanyName+" "
                    +list.ContactName+" "
                    +list.ContactTitle+" "
                    +list.Country+" "
                    +list.CustomerDemographics+" "
                    +list.CustomerID+" "
                    +list.Fax+" "
                    +list.Orders+" "
                    +list.Phone+" "
                    +list.PostalCode+" "
                    +list.Region+" ");
            }
        }
        public void MostrarProductosSinStock()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var lista = productsQuerys.ObtenerProductsSinStock(context);
            foreach (var productos in lista)
            {
                Console.WriteLine(productos.ProductName+" "+
                                  productos.ProductID);
            }
        }
        public void MostrarProductosConStockYMasDeTres()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var lista = productsQuerys.ObternerProductConMasDeTres(context);
            foreach (var productos in lista)
            {
                Console.WriteLine(productos.ProductName + " " +
                                  productos.ProductID+" "+
                                  productos.UnitsInStock+" "+
                                  productos.UnitPrice);
            }
        }
        public void MostrarPrimerosTresCustomersDeWA()
        {
            CostumersQuery customersQuerys = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = customersQuerys.ObtenerPrimerosTresDeWA(context);
            foreach (var list in lista)
            {
                Console.WriteLine(list.CustomerID + " "
                    + list.Address + " "
                    + list.City + " "
                    + list.CompanyName + " "
                    + list.ContactName + " "
                    + list.ContactTitle + " "
                    + list.Country + " "
                    + list.CustomerDemographics + " "
                    + list.CustomerID + " "
                    + list.Fax + " "
                    + list.Orders + " "
                    + list.Phone + " "
                    + list.PostalCode + " "
                    + list.Region + " ");
            }
        }
        public void MostrarPrimerProductoSinStockONulo()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var productos = productsQuerys.PrimerProductoIdSetecientosOchenteYNueve(context);
            Console.WriteLine(productos.ProductName + " " +
                              productos.ProductID + " " +
                              productos.UnitsInStock + " " +
                              productos.UnitPrice);
        }
        public void MostrarNombreDeCustomers()
        {
            CostumersQuery customersQuerys = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = customersQuerys.ObtenerNombresDeLosCustomers(context);
            foreach(var nombre in lista)
            {
                Console.WriteLine(nombre.ToLower()+""+nombre.ToUpper());
            }
        }
        public void MostrarJoinCustomersYOrders()
        {
            CostumersQuery customersQuerys = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = customersQuerys.ObtenerJoinCustomersOrders(context);
            foreach (var list in lista)
            {
                Console.WriteLine(list.CustomerID + " "
                    + list.Address + " "
                    + list.City + " "
                    + list.CompanyName + " "
                    + list.ContactName + " "
                    + list.ContactTitle + " "
                    + list.Country + " "
                    + list.CustomerDemographics + " "
                    + list.CustomerID + " "
                    + list.Fax + " "
                    + list.Orders + " "
                    + list.Phone + " "
                    + list.PostalCode + " "
                    + list.Region + " ");
            }
        }
        public void MostarCustomersDeWA()
        {
            CostumersQuery customersQuerys = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = customersQuerys.ObtenerCutomersDeWashington(context);
            foreach (var list in lista)
            {
                Console.WriteLine(list.CustomerID + " "
                    + list.Address + " "
                    + list.City + " "
                    + list.CompanyName + " "
                    + list.ContactName + " "
                    + list.ContactTitle + " "
                    + list.Country + " "
                    + list.CustomerDemographics + " "
                    + list.CustomerID + " "
                    + list.Fax + " "
                    + list.Orders + " "
                    + list.Phone + " "
                    + list.PostalCode + " "
                    + list.Region + " ");
            }
        }
        public void MostarProductosOrdenadosPorNombre()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var lista = productsQuerys.OtenerProductosOrdenadosPorNombre(context);
            foreach (var productos in lista)
            {
                Console.WriteLine(productos.ProductName + " " +
                                  productos.ProductID + " " +
                                  productos.UnitsInStock + " " +
                                  productos.UnitPrice);
            }
        }
        public void MostrarProductosOrdenadosPorUnit()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var lista = productsQuerys.ObtenerProductosPorStockDeMayorAMenor(context);
            foreach (var productos in lista)
            {
                Console.WriteLine(productos.ProductName + " " +
                                  productos.ProductID + " " +
                                  productos.UnitsInStock + " " +
                                  productos.UnitPrice);
            }

        }
        public void MostrarCategoriasAsociadasAProductos()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var lista = productsQuerys.ObtenerProductosConSusCategorias(context);
            Console.WriteLine(lista);
        }
        public void MostrarPrimerProducto()
        {
            ProductsQuerys productsQuerys = new ProductsQuerys();
            NorthWindContext context = new NorthWindContext();
            var productos = productsQuerys.ObtenerPrimerProducto(context);
            Console.WriteLine(productos.ProductName + " " +
                              productos.ProductID + " " +
                              productos.UnitsInStock + " " +
                              productos.UnitPrice);
        }
        public void MostarCustomersConOrdenesAsociadas()
        {
            CostumersQuery costumersQuery = new CostumersQuery();
            NorthWindContext context = new NorthWindContext();
            var lista = costumersQuery.CustomersConOrdenesAsociadas(context);
            Console.WriteLine(lista);
        }
    }
}
