using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRentalStore.Models;

namespace VideoRentalStore
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            VideoRentalStoreRepository v = new VideoRentalStoreRepository();
            if (Page.IsValid)
            {
                Customer customer = new Customer()
                {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    Address = tbxAddress.Text,
                    PhoneNumber = tbxPhoneNumber.Text
                };

                v.AddNewCustomer(customer);

                Response.Redirect("~/Default.aspx");
            }
        }
    }
}