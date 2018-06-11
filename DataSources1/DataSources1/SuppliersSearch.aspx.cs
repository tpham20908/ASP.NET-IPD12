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
    public partial class SuppliersSearch : System.Web.UI.Page
    {
        private string ConStr = ConfigurationManager
            .ConnectionStrings["NORTHWNDConnectionString2"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            // Populate dropdown list
            SqlConnection con = new SqlConnection(ConStr);


            try
            {
                string sql = "SELECT * FROM Suppliers";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ListItem newItem = new ListItem();
                newItem.Text = "Please select a supplier";
                newItem.Value = "";
                ddlSuppliers.Items.Add(newItem);
                while (reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = reader["SupplierID"] + ". " + reader["CompanyName"];
                    item.Value = reader["SupplierID"].ToString();
                    ddlSuppliers.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                lblConnection.Text = "Connection failed!";
            }
            finally
            {
                con.Close();
                // lblConnection.Text += "Connection closed!";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);

            try
            {
                lbxSuppliers.Items.Clear();

                string sql = "SELECT * FROM Suppliers WHERE SupplierID = " + tbxSupplierID.Text;

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbxSuppliers.Items.Add("ID: " + reader["SupplierID"]);
                    lbxSuppliers.Items.Add("Name: " + reader["CompanyName"]);
                    lbxSuppliers.Items.Add("Address: " + reader["Address"]);
                    lbxSuppliers.Items.Add("Phone: " + reader["Phone"]);
                }
                else
                    lbxSuppliers.Items.Add("No record found");
            }
            catch (Exception ex)
            {
                lblConnection.Text = "Connection failed!";
            }
            finally
            {
                con.Close();
                // lblConnection.Text += "Connection closed!";
            }
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);

            try
            {
                lbxSuppliers.Items.Clear();

                string sql = "SELECT * FROM Suppliers WHERE SupplierID = " + ddlSuppliers.SelectedValue;

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader;
                con.Open();

                reader = cmd.ExecuteReader();

                dvSupplier.DataSource = reader;
                dvSupplier.DataBind();
            }
            catch (Exception ex)
            {
                lblConnection.Text = "Connection failed!";
            }
            finally
            {
                con.Close();
                // lblConnection.Text += "Connection closed!";
            }
        }
    }
}