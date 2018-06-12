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
                List<Product> products = new List<Product>();

                List<int> productIds = (from od in context.Order_Details
                                                   where od.OrderID == id
                                                   select od.ProductID).ToList();

                foreach (int prodId in productIds)
                {
                    List<Product> prods = (from p in context.Products
                                 where p.ProductID == prodId
                                 select p).ToList();
                    products.AddRange(prods);
                }

                return products;
            }
        }
    }
}