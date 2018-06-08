using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            if (ckbxSameAddress.Checked)
            {
                tbxShippingAddress.Enabled = false;
                tbxShippingCity.Enabled = false;
                ddlShippingState.Enabled = false;
                tbxShippingZip.Enabled = false;
                tbxShippingAddress.Text = tbxBillingAddress.Text;
                tbxShippingCity.Text = tbxBillingCity.Text;
                ddlShippingState.SelectedValue = ddlBillingState.SelectedValue;
                tbxShippingZip.Text = tbxBillingZip.Text;
                RequiredFieldValidator7.Enabled = false;
                RequiredFieldValidator8.Enabled = false;
                RequiredFieldValidator9.Enabled = false;
                RequiredFieldValidator10.Enabled = false;
            } else
            {
                tbxShippingAddress.Enabled = true;
                tbxShippingCity.Enabled = true;
                ddlShippingState.Enabled = true;
                tbxShippingZip.Enabled = true;
                RequiredFieldValidator7.Enabled = true;
                RequiredFieldValidator8.Enabled = true;
                RequiredFieldValidator9.Enabled = true;
                RequiredFieldValidator10.Enabled = true;
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string bilAdd = string.Format(
                    "Billing Address: {0} {1} {2} {3}",
                    tbxBillingAddress.Text, tbxBillingCity.Text, 
                    ddlBillingState.SelectedValue, tbxBillingZip.Text
                    );

                string shplAdd = string.Format(
                    "Shipping Address: {0} {1} {2} {3}",
                    tbxShippingAddress.Text, tbxShippingCity.Text,
                    ddlShippingState.SelectedValue, tbxShippingZip.Text
                    );

                StringBuilder output = new StringBuilder();
                output.AppendLine("Full Name: " + tbxFirstName.Text + " " + tbxLastName.Text);
                output.AppendLine("Email: " + tbxEmail.Text);
                output.AppendLine("Phone number: " + tbxPhoneNumber.Text);
                output.AppendLine(bilAdd);
                output.AppendLine(shplAdd);

                lblSummary.Text = output.ToString().Replace(Environment.NewLine, "<br/>");
            }
        }
    }
}