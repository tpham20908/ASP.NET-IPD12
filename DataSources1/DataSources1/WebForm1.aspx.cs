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
                ddlBinding.DataBinding += this.ddlBinding_Event;
                // Yes, No, Maybe, OK
                var answer = new string[] { "Yes", "No", "Maybe", "OK" };
                // Sourse
                ddlBinding.DataSource = answer;
                // Binding
                ddlBinding.DataBind();

                // Listbox binding:  array of towns, where each town has and ID and a name
                var towns = new[]
                {
                    new{ID = 1, Name = "Montreal"},
                    new{ID = 2, Name = "Calgary"},
                    new{ID = 3, Name = "Toronto"},
                    new{ID = 4, Name = "Quebec"},
                    new{ID = 5, Name = "Ottawa"},
                    new{ID = 6, Name = "Vancouver"}
                };

                // Sourse
                lbxTowns.DataSource = towns;
                lbxTowns.DataBind();

                // Bullet list
                var searchEngine = new[]
                {
                    new {Name = "Google", URL = "http://www.google.com" },
                    new {Name = "Bing", URL = "http://www.bing.com" },
                    new {Name = "MSDN", URL = "http://www.msdn.microsoft.com" },
                    new {Name = "Yahoo", URL = "http://www.yahoo.com" }
                };

                bltSearch.DataSource = searchEngine;
                bltSearch.DataBind();
            }
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDDLBinding.Text = "Your answer is " + ddlBinding.SelectedValue.ToString();
        }

        protected void ddlBinding_Event(object sender, EventArgs e)
        {
            lblDDLBinding.Text = "The DDL is now binded.";
        }

        protected void lbxTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTown.Text = "You hav selected: " + lbxTowns.SelectedItem.ToString()
                + " - ID: " + lbxTowns.SelectedValue;
        }
    }
}