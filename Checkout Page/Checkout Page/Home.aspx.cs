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

            if (ckbxSameAddress.Checked)
            {
                tbxShippingAddress.Enabled = false;
                tbxShippingCity.Enabled = false;
                ddlShippingState.Enabled = false;
                tbxShippingZip.Enabled = false;
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
    }
}