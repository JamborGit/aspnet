using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnet.Samples
{
    public partial class Gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = new List<Customer>(){
                 new Customer(){Name="jambor" ,Age="1"},
                 new Customer(){Name="yao" ,Age="1"},
           };
            myGrid.DataSource = customerList;
            myGrid.DataBind();
        }

        protected void myDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void myGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.DataRow)
            {
                return;
            }
            DropDownList myDropdown = (DropDownList)e.Row.FindControl("myDropdown");
           //  List<Customer> customerList = new List<Customer>(){
           //      new Customer(){Name="jambor" ,Age="1"},
           //      new Customer(){Name="yao" ,Age="1"},
           //};
            //myDropdown.DataSource = ArrayList;
            //myDropdown.DataTextField = "Name";
            //myDropdown.DataValueField = "Age";
            //myDropdown.DataBind();
            ArrayList list = new ArrayList();
            list.Add("none");
            list.Add("Canada Post");
            list.Add("UPS");

            list.Insert(1, "FedEx");

            myDropdown.DataSource = list;
            myDropdown.DataBind();
         
        }


    }
    public class Customer
    {
        public string Name { set; get; }
        public string Age { set; get; }
    }
}