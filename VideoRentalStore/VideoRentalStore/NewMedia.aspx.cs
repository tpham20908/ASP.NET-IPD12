using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRentalStore.Models;

namespace VideoRentalStore
{
    public partial class NewMedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAddNewMedia_Click(object sender, EventArgs e)
        {
            VideoRentalStoreRepository v = new VideoRentalStoreRepository();
            if (Page.IsValid)
            {
                Media media = new Media()
                {
                    Title = tbxTitle.Text,
                    Type = tbxType.Text,
                    ProductionYear = int.Parse(tbxYear.Text)
                };

                v.AddNewMedia(media);

                Response.Redirect("~/Default.aspx");
            }
        }
    }
}