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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchTitle_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnRent_Click(object sender, EventArgs e)
        {
            VideoRentalStoreRepository v = new VideoRentalStoreRepository();

            int customerId = int.Parse(Request.QueryString["CustomerId"]);
            List<int> mediaIdList = new List<int>();

            string items = "";
            
            foreach (ListItem item in cblTitles.Items)
            {
                if (item.Selected)
                {
                    mediaIdList.Add(int.Parse(item.Value));
                    items += item.Text + ", ";
                }
            }

            v.AddRentalRecord(customerId, mediaIdList);

            foreach (ListItem item in cblTitles.Items)
            {
                item.Selected = false;             
            }

            if (!String.IsNullOrEmpty(items))
                lblAnnouncement.Text = "You have rented " + items + "succesfully. Thank you!";

        }
    }
}