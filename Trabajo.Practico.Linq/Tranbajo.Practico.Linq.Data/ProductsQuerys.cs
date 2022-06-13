using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranbajo.Practico.Linq.Entities;

namespace Tranbajo.Practico.Linq.Data
{
    public class ProductsQuerys
    {
        public List<Products> ObtenerProductsSinStock(NorthWindContext context)
        {
            return context.Products.Where(p => p.UnitsInStock.Equals(0)).ToList();
        }
        public List<Products> ObternerProductConMasDeTres(NorthWindContext context)
        {
            return context.Products.Where(p => p.UnitsInStock > 0).Where(p=>p.UnitPrice>3).ToList();
        }
        public Products PrimerProductoIdSetecientosOchenteYNueve(NorthWindContext context)
        {
            var query = from Products in context.Products
                        where Products.ProductID == 789
                        orderby Products.ProductID descending
                        select Products;
            
            return query.First();
        }
        public List<Products> OtenerProductosOrdenadosPorNombre(NorthWindContext context)
        {
            return context.Products.OrderBy(p=>p.ProductName).ToList();
        }
        public List<Products> ObtenerProductosPorStockDeMayorAMenor(NorthWindContext context)
        {
            var query = from Products in context.Products
                        where Products.UnitsInStock > 0
                        orderby Products.UnitsInStock descending
                        select Products;
            return query.ToList();
        }
        public Products ObtenerPrimerProducto(NorthWindContext context)
        {
            return context.Products.First();
        }
        public IQueryable ObtenerProductosConSusCategorias(NorthWindContext context)
        {
            return from Products in context.Products
                   join Categories in context.Categories
                   on Products.CategoryID equals Categories.CategoryID
                   select new {Categories.CategoryName, Products.ProductName };
        }//Tal vez deberia estar en una clase CategoriasQuery
    }
}
