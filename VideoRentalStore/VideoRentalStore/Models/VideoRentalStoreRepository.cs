using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalStore.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDBContext _context = new VideoRentalStoreDBContext();

        // get all customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        // get customer by Id
        public Customer GetCustomerById(int id)
        {
            return GetCustomers().FirstOrDefault(c => c.ID == id);
        }

        // update customer
        public void UpdateCustomer(int id)
        {
            Customer c = GetCustomerById(id);
            if (c != null)
            {
            }
        }
    }
}