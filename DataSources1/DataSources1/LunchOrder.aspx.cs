using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class LunchOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cities = new string[]
            {
                "Montreal", "Quebec", "Laval", "St.Jerome", "Brossard"
            };

            var genders = new string[]
            {
                "Male", "Female", "Other"
            };

            var meals = new string[]
            {
                "Burger", "Steak", "Salad", "Coke"
            };

            var payments = new string[]
            {
                "Cash", "Credit Card", "Android pay", "Apple pay"
            };

            lbxCity.DataSource = cities;
            lbxCity.DataBind();

            ddlGender.DataSource = genders;
            ddlGender.DataBind();

            cbxMeal.DataSource = meals;
            cbxMeal.DataBind();

            rbtnPayment.DataSource = payments;
            rbtnPayment.DataBind();
        }

        string customerInfo = "";

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            var meal = "";

            foreach (ListItem item in cbxMeal.Items)
            {
                if (item.Selected) {
                    meal += item + "";
                }
            }

            //customerInfo += tbxName.Text;

            var customerInfo =
                "Name: " + tbxName.Text + " | "
                + "City: " + lbxCity.SelectedItem + " | "
                + "Gender: " + ddlGender.SelectedItem + " | "
                + "Meal option: " + meal + " | "
                + "Payment: " + rbtnPayment.SelectedItem + " | ";

            lbxDetail.Items.Add(customerInfo);
        }

        protected void lbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text += lbxCity.SelectedItem + "";
            customerInfo += lbxCity.SelectedValue;
        }

        protected void ddlGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = ddlGender.SelectedValue.ToString();
        }

        protected void cbxMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text += cbxMeal.SelectedItem + "";
            customerInfo += cbxMeal.SelectedValue;
        }

        protected void rbtnPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}