using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranbajo.Practico.Linq.Entities;

namespace Tranbajo.Practico.Linq.Data
{
    public class CostumersQuery
    {
        public List<Customers> ObtenerCustomers(NorthWindContext context)
        {
            var query = context.Customers.Where(c =>c.CustomerID!=null).ToList();
                        
            return query;
        }
        public List<Customers> ObtenerCutomersDeWashington(NorthWindContext context)
        {
            var query = from Customers in context.Customers
                        where Customers.Region == "WA"
                        orderby Customers.CustomerID
                        select Customers; 
            return query.ToList();
        }
        public List<string> ObtenerNombresDeLosCustomers(NorthWindContext context)
        {
            var query =from Customers in context.Customers
                       where Customers.CompanyName!=null
                       select Customers.CompanyName;
            return query.ToList();
        }
        public List<Customers> ObtenerJoinCustomersOrders(NorthWindContext context)
        {
            var query = from Customers in context.Customers
                        join Orders in context.Orders
                        on Customers.CustomerID equals Orders.CustomerID
                        where Customers.City == "WA"
                        where Orders.OrderDate > DateTime.Parse("01/01/1997")
                        select Customers;
            return query.ToList();
        }
        public List<Customers> ObtenerPrimerosTresDeWA(NorthWindContext context)
        {
            return context.Customers.Where(c => c.Region.Equals("WA")).Take(3).ToList();
        }
        public IQueryable CustomersConOrdenesAsociadas(NorthWindContext context)
        {
            var query = (from Orders in context.Orders
                         join Customers in context.Customers
                         on Orders.CustomerID equals Customers.CustomerID
                         orderby Customers.CustomerID
                         select new {Orders.CustomerID, Customers });

            return query;
        }
    }
}
