using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace DataSources1
{
    public partial class Shippers : System.Web.UI.Page
    {
        private string ConStr = ConfigurationManager
            .ConnectionStrings["NORTHWNDConnectionString2"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConStr);
                try
                {
                    string query = "SELECT * FROM Shippers";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    grvShippers.DataSource = reader;
                    grvShippers.DataBind();
                    
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);
            try
            {
                string query = "INSERT INTO Shippers(CompanyName, Phone) VALUES ('" +
                    tbxName.Text + "', '" + tbxPhone.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                lblResult.Text = "Shipper added succesfully";
                Response.Redirect("~/Shippers.aspx");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}