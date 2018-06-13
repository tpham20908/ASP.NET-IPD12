using ObjectDS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectDS.BAL
{
    public class BAL_OrderSearch
    {
        NorthwindDBDataContext context = new NorthwindDBDataContext();
        
        public List<Order> GetOrders(DateTime date)
        {
            using (context)
            {
                List<Order> orders = (from o in context.Orders
                                      where o.OrderDate == date
                                      select o).ToList();
                return orders;
            }
        }

        public List<Product> GetProducts(int OrderId)
        {
            using (context)
            {
                List<Product> products = (from p in context.Products
                                          join od in context.Order_Details
                                          on p.ProductID equals od.ProductID
                                          where od.OrderID == OrderId
                                          select p).ToList();
                return products;
            }
        }

        // ProductID, ProductName, Price, Quantity, Discount
        public Object GetCustomedProductList(int OrderId)
        {
            using (context)
            {
                var products = (from p in context.Products
                                join od in context.Order_Details
                                on p.ProductID equals od.ProductID
                                where od.OrderID == OrderId
                                select new {
                                    p.ProductID, p.ProductName, od.UnitPrice, od.Quantity, od.Discount
                                }).ToList();
                return products;
            }
        }
    }
}