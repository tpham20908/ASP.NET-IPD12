﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRentalStore.Models;

namespace VideoRentalStore
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRentMedia.Visible = false;
        }

        protected void gvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRentMedia.Visible = true;
            lblId.Text = gvCustomers.SelectedValue.ToString();
        }

        protected void btnRentMedia_Click(object sender, EventArgs e)
        {
            Response.Redirect(
                "~/RentMedia.aspx?CustomerId=" +
                gvCustomers.SelectedValue
                );
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvCustomers.SelectedValue != null)
            {
                int id = (int)gvCustomers.SelectedValue;
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string address = tbxAddress.Text;
                string phoneNumber = tbxPhoneNumber.Text;

                (new VideoRentalStoreRepository()).UpdateCustomer(id, firstName, lastName, address, phoneNumber);

                Response.Redirect("~/Customers.aspx");
            }
        }
    }
}