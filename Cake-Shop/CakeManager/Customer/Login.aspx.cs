using Customer.localhost;
using System;
namespace Customer
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string alertStr = Request.Params["alert"];
            if (alertStr != null)
            {
                if (alertStr.Length != 0)
                {
                    alert.Text = alertStr;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerServices services = new CustomerServices();
            tblCustomer c = services.checkLogin(txtPhone.Value, txtPassword.Value);
            if (c == null)
            {
                alert.Text = "Wrong phone or password";
            }
            else
            {
                DAOLibrary.tblCustomer customer = new DAOLibrary.tblCustomer();
                customer.address = c.address;
                customer.birthday = c.birthday;
                customer.customerId = c.customerId;
                customer.email = c.email;
                customer.fullname = c.fullname;
                customer.phone = c.phone;
                Session.Add("LoginInfo", customer);
                Response.Redirect("Home.aspx");
            }
        }

    }
}