using Exam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam1.BAL
{
    public class BAL_Suppliers
    {
        DSSuppliersDataContext _context = new DSSuppliersDataContext();

        public List<Supplier> GetSuppliersByCity(string cityName)
        {
            List<Supplier> suppliers = (from s in _context.Suppliers
                                        where s.City.Equals(cityName)
                                        select s).ToList();
            return suppliers;
        }

        public void AddProducts(int SupplierID, int CategoryID)
        {
            //NORTHWNDConnectionString
        }
    }
}