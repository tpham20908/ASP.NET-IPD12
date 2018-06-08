using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class Customer_Detail_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)
            SqlAllCustomers.SelectCommand = "SELECT * FROM [Customers] " +
                "WHERE ([" + ddl.SelectedValue + "] = @CustomerID)";
        }
    }
}