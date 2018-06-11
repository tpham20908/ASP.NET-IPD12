﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class SearchForOrder : System.Web.UI.Page
    {
        private string ConStr = ConfigurationManager
            .ConnectionStrings["NORTHWNDConnectionString2"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);

            try
            {

                string sql = "SELECT * FROM Orders WHERE OrderID = " + tbxOrderID.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtlResult.DataSource = reader;
                dtlResult.DataBind();

                // get either customer or shipper
                string optionChosen = getOption();

                if (optionChosen == "Customer")
                {
                    string option = (string)reader["CustomerID"];
                    string sql2 = "SELECT * FROM Customers WHERE CustomerID = '" + option + "'";
                    cmd = new SqlCommand(sql2, con);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lbxResult.Items.Add("ID: " + reader["CustomerID"]);
                        lbxResult.Items.Add("Name: " + reader["CompanyName"]);
                        lbxResult.Items.Add("Address: " + reader["Address"]);
                        lbxResult.Items.Add("Phone: " + reader["Phone"]);
                    }
                    else
                        lbxResult.Items.Add("No record found");
                }
                    
                else
                {
                    string option = (string)reader["ShipName"];
                    string sql2 = "SELECT * FROM Customers WHERE CustomerID = " + option;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
                // lblConnection.Text += "Connection closed!";
            }
        }
           
        public string getOption()
        {
            if (ddlOptions.SelectedValue == "Customer")
                return "CustomerID";
            else
                return "ShipVia";
        }
    }
}