using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class SearchForOrder_Home : System.Web.UI.Page
    {
        private string ConStr = ConfigurationManager
            .ConnectionStrings["NORTHWNDConnectionString"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);

            try
            {
                string sql = "SELECT * FROM Orders WHERE OrderID = " + tbxOrderId.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dvResult.DataSource = reader;
                dvResult.DataBind();

                switch (ddlOptions.SelectedValue)
                {
                    case "Customer":
                        sql = "SELECT * FROM Customers WHERE CustomerID = '"
                            + dvResult.Rows[1].Cells[1].Text + "'";
                        break;
                    case "Shipper":
                        sql = "SELECT * FROM Shippers WHERE ShipperID = '"
                            + dvResult.Rows[6].Cells[1].Text + "'";
                        break;
                }

                reader.Close();
                lbxOption.Items.Clear();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    lbxOption.Items.Add(reader[i].ToString());
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}