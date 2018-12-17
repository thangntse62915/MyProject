using DAOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEmployee
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string naddress = txtAddress.Text;
            string nphone = txtPhone.Text;
            string nbirthday = txtBirthday.Text;
            if (id.Equals("") || name.Equals("") || naddress.Equals("") || txtPhone.Equals(""))
            {
                MessageBox.Show("Information of customer is not blank", "Message");
                return;
            }
            tblCustomer cus = new tblCustomer { customerId = id, fullname = name, address = naddress, phone = nphone, password = "12345", enable = true,birthday =  DateTime.Parse(nbirthday)};

            CustomerDAO dao = new CustomerDAO();
            string result = dao.insertCustomer(cus);
            if (result.Equals(""))
            {
                MessageBox.Show("New Customer has been created.", "Message");
                btnNew_Click(null, null);
            }
            else if(result.Equals("Phone"))
            {
                MessageBox.Show("This phone is exist", "Message");
            }
            else{
                MessageBox.Show("This Id is exist", "Message");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
    }
}
