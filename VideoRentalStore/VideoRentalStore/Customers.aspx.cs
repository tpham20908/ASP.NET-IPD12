using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VideoRentalStore
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRentMedia.Visible = false;
            btnUpdateCustomer.Visible = false;
        }

        protected void gvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRentMedia.Visible = true;
            btnUpdateCustomer.Visible = true;
        }

        protected void btnRentMedia_Click(object sender, EventArgs e)
        {
            Response.Redirect(
                "~/RentMedia.aspx?CustomerId=" +
                gvCustomers.SelectedValue
                );
        }
    }
}