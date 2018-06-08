using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkout_Page
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            loadingStates();

            if (ckbxSameAddress.Checked)
            {
                tbxShippingAddress.Enabled = false;
                tbxShippingCity.Enabled = false;
                ddlShippingState.Enabled = false;
                tbxShippingZip.Enabled = false;
                //RequiredFieldValidator7.Enabled = false;
                //RequiredFieldValidator8.Enabled = false;
                //RequiredFieldValidator9.Enabled = false;
                //RequiredFieldValidator10.Enabled = false;
            } else
            {
                tbxShippingAddress.Enabled = true;
                tbxShippingCity.Enabled = true;
                ddlShippingState.Enabled = true;
                tbxShippingZip.Enabled = true;
                //RequiredFieldValidator7.Enabled = true;
                //RequiredFieldValidator8.Enabled = true;
                //RequiredFieldValidator9.Enabled = true;
                //RequiredFieldValidator10.Enabled = true;
            }
        }

        private void loadingStates()
        {
            var States = new[]
            {
                new { ID = 0, Name = ""},
                new { ID = 1, Name = "WA"},
                new { ID = 2, Name = "MI"},
                new { ID = 3, Name = "CA"},
                new { ID = 4, Name = "WC"},
                new { ID = 5, Name = "LA"},
                new { ID = 6, Name = "VA"}
            };

            ddlBillingState.DataSource = States;
            ddlBillingState.DataBind();
            ddlBillingState.SelectedIndex = 0;

            ddlShippingState.DataSource = States;
            ddlShippingState.DataBind();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (ddlBillingState.SelectedIndex == 0)
            {
                lblSummary.Text = "Empty";
            }
        }
    }
}