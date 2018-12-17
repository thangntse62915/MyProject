using DAOLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }

        }
        public void loadData()
        {
            
            Cart cart = (Cart)Session["MyCart"];
            RepeaterCart.DataSource = null;
            RepeaterCart.DataSource = cart.list;


        }

     
    }
}