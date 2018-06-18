using Exam1.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class NewProduct : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            ddlCategories.Items.Add("Please select a Category");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Page previous = Page.PreviousPage;
            int categoryID = int.Parse(Session["CategoryID"].ToString());
            // get supplierId from query string
            int supplierID = int.Parse(Request.QueryString["SupplierID"]);

            

            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    string query =
                        "INSERT INTO Products VALUES ('" +
                        tbxName.Text + "','" +
                        tbxQuantity.Text + "','" +
                        tbxUnitPrice.Text + "','" +
                        tbxUnitInStock.Text + "','" +
                        tbxUnitsOnOrder.Text + "','" +
                        tbxOrderLevel.Text + "','" +
                        (cbxDiscontinued.Checked? "'True'" : "'False'") + "')" +
                        "WHERE CategoryID = 3 " +
                        " AND SupplierID = " + supplierID;

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    lblTest.Text = "Shipper added succesfully";                    
                }
                catch (Exception er)
                {
                    lblTest.Text = er.Message;
                }
            }
        }
    }
}