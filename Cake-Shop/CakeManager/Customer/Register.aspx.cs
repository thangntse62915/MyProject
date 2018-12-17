using Customer.localhost;
using System;

namespace Customer
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            tblCustomer c = new tblCustomer()
            {
                address = txtAddress.Value,
                birthday = DateTime.Parse(txtBirthday.Text),
                email = txtEmail.Value,
                enable = true,
                fullname = txtFullname.Value,
                password = txtPassword.Value,
                phone = txtPhone.Value,
                customerId = txtId.Value
            };
            CustomerServices services = new CustomerServices();
            string result = services.register(c);
            if (result.Contains("Id"))
            {
                alert.Text = "duplicate Id";
            }
            else if (result.Contains("Phone"))
            {
                alert.Text = "duplicate Phone";
            }
            else
            {
                Response.Redirect("Login.aspx?alert=Register success, please login");
            }

        }
        
    }
}