using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.SetFocus(ddlBinding);

            if (!Page.IsPostBack)
            {
                // Yes, No, Maybe, OK
                var answer = new string[] { "Yes", "No", "Maybe", "OK" };
                // Sourse
                ddlBinding.DataSource = answer;
                // Binding
                ddlBinding.DataBind();


            }
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDDLBinding.Text = "Your answer is " + ddlBinding.SelectedValue.ToString();
        }
    }
}