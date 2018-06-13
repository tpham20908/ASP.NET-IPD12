using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectDS.Data;

namespace ObjectDS.BAL
{
    public class BAL_Countries
    {
        private BAL_NorthwindDataContext _context;

        //public BAL_Countries(BAL_NorthwindDataContext context)
        //{
        //    _context = context;
        //}

        public List<string> GetAllCountries()
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                List<string> countriesList = (from c in context.Customers
                                             select c.Country).Distinct().ToList();
                return countriesList;
            }
        }

        public List<Customer> GetCustomersByCountry(string country)
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                List<Customer> customerList = (from c in context.Customers where c.Country == country
                                               select c).Distinct().ToList();
                return customerList;
            }
        }

        public Customer GetCustomer(string CustomerID)
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                Customer c = (from cust in context.Customers
                              where cust.CustomerID == CustomerID
                              select cust).SingleOrDefault();
                return c;
            }
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                List<Order> orders = (from order in context.Orders
                                      where order.OrderDate == date
                                      select order).ToList();
                return orders;
            }
        }

        public List<Product> GetProducts(int id)
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                List<Product> products = (from p in context.Products
                                          join od in context.Order_Details
                                          on p.ProductID equals od.ProductID
                                          where od.OrderID == id
                                          select p).ToList();
                return products;
            }
        }

        //Select Product ID, Product Name, Price, Quantity & Discount
        public object GetCustomedProducts(int id)
        {
            using (var context = new BAL_NorthwindDataContext())
            {
                var products = (from p in context.Products
                                          join od in context.Order_Details
                                          on p.ProductID equals od.ProductID
                                          where od.OrderID == id
                                          select new {
                                              p.ProductID, p.ProductName, od.UnitPrice, od.Quantity, od.Discount
                                          }).ToList();
                return products;
            }
        }
    }
}