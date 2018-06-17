using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRentalStore.Models;

namespace VideoRentalStore
{
    public partial class RentMedia : System.Web.UI.Page
    {
        VideoRentalStoreRepository v = new VideoRentalStoreRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count == 0)
            {
                btnRent.Visible = false;
                //Response.Write("<img src=\"Images/customerOnly.jpg\">");
                //Response.Write("<h2>No shortcut, Please!!!</h2>");
                //Page.Visible = false;
            }
        }

        protected void btnSearchTitle_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnRent_Click(object sender, EventArgs e)
        {
            // get customer id from query string
            int customerId = int.Parse(Request.QueryString["CustomerId"]);

            List<int> mediaIdList = new List<int>();

            string items = "";
            
            // iterate check box list to find item selected
            foreach (ListItem item in cblTitles.Items)
            {
                if (item.Selected)
                {
                    mediaIdList.Add(int.Parse(item.Value));
                    items += item.Text + ", ";
                }
            }

            // add RentalRecords of selected customer
            v.AddRentalRecord(customerId, mediaIdList);
            
            // uncheck all check box list items
            foreach (ListItem item in cblTitles.Items)
            {
                item.Selected = false;             
            }

            // showing label as customer rented rented successfully
            if (!String.IsNullOrEmpty(items))
                lblAnnouncement.Text = "You have rented " + items + "succesfully. Thank you!";

            // refresh the grid view of rented media
            Response.Redirect("~/RentMedia.aspx?CustomerId=" + customerId);
        }
    }
}