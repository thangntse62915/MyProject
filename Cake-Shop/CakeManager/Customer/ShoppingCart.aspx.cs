using DAOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer
{
    public partial class ShoppingCart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                Cart list = (Cart)Session["MyCart"];
                if (list != null)
                {

                    Repeater3.DataSource = null;
                    Repeater3.DataSource = ((Cart)Session["MyCart"]).list;
                    Repeater3.DataBind();
                }
            }


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Response.Redirect("ShoppingCart.aspx");


        }
        protected void Delete_Click(object sender, EventArgs e)
        {

            Cart cart = (Cart)Session["MyCart"];
            String id = ((Button)sender).CommandArgument.ToString();
            cart.deleteCake(id);
            Session["MyCart"] = cart;
            Response.Redirect("ShoppingCart.aspx");


        }
        protected void Update_Click(object sender, EventArgs e)
        {
            tblCake c;
            int quanti;
            Cart xcart = (Cart)Session["MyCart"];
            if (xcart == null) return;
            foreach (RepeaterItem item in Repeater3.Items)
            {
                
                TextBox tb = (TextBox)item.FindControl("txtQuantity");
                HiddenField hd = (HiddenField)item.FindControl("txtHidden");
                try
                {
                    c = xcart.list.Where(x => x.cakeId.Equals(hd.Value)).SingleOrDefault();
                    quanti = int.Parse(tb.Text);
                    if(quanti > 0) { c.quantity = quanti; }
                    xcart.Sumtotal();
                  
                }
                catch
                {

                }
               
            }
            Repeater3.DataSource = null;
            Repeater3.DataSource = xcart.list;
            Repeater3.DataBind();




        }

        protected void CheckOut_Click(object sender, EventArgs e)
        {
          
            DAOLibrary.tblCustomer cus = (DAOLibrary.tblCustomer)Session["LoginInfo"];
            Cart xcart = (Cart)Session["MyCart"];
            if (cus == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if(xcart == null||xcart.list.Count == 0)
            {
                txtMes.Text = "Please choose cake first !";
            }
            else
            {
                List<localhost.tblCake> listLocal = new List<localhost.tblCake>();
                foreach (DAOLibrary.tblCake item in xcart.list)
                {
                    localhost.tblCake c = new localhost.tblCake ();
                    c.cakeId = item.cakeId;
                    c.name = item.name;
                    c.price = item.price;
                    c.quantity = item.quantity;
                    listLocal.Add(c);


                }
                localhost.CustomerServices services = new localhost.CustomerServices();
                string mess = services.checkListOrder(listLocal.ToArray());
                if (!mess.Equals("")) { 
                txtMes.Text = mess +" is limit quantity  ";
                }
                else
                {
                    
                    localhost.tblCustomer cuss = ConvertUtil.ConvertLDC(cus);

                    services.insertOrder(ConvertUtil.ConvertLDC(cus), listLocal.ToArray());
                    txtMes.Text = "Order successful";
                    Session["MyCart"] = new Cart();
                    Response.Redirect("Home.aspx");
                }

            }
            

        }
    }
}