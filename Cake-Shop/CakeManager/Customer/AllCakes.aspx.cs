﻿using DAOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer
{
    public partial class AllCakes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();

            }

        }
        public void loadData()
        {

            IEnumerable<tblCake> dt;
            CakeShopEntities ctx = new CakeShopEntities();
            dt = ctx.tblCakes.Where(x => x.name.Contains("")).ToList();
            Repeater1.DataSource = null;
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            Cart cart = (Cart)Session["MyCart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["MyCart"] = cart;
            }

            Button bt = (Button)sender;
            string[] cakeInfo = bt.CommandArgument.ToString().Split(new char[] { ',' });
            cart.addCake(cakeInfo[0], cakeInfo[1], float.Parse(cakeInfo[2]));
          
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Response.Redirect("ShoppingCart.aspx");


        }

    }
}