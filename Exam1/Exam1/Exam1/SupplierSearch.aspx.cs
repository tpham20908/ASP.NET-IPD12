using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class SupplierSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSuppliers.Items.Add("Please select a company");
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/NewProduct.aspx?SupplierID=" 
                + Server.UrlEncode(ddlSuppliers.SelectedValue.ToString()));
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/NewProduct.aspx?SupplierID="
                + Server.UrlEncode(ddlSuppliers.SelectedValue.ToString()));
            // store categoryID in session
            Session["CategoryID"] = GridView1.DataKeyNames;
        }
    }
}