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
    public partial class LoginBakery : Form
    {
        public LoginBakery()
        {
            InitializeComponent();
            lbErr.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { EmployeeDAO dao = new EmployeeDAO();
            Employee em = dao.checkLogin(txtUsername.Text, txtPassword.Text);

            if (em== null)
            {
                lbErr.Visible = true;
            }
            else
            {
               
                new SellForm(em).Visible = true;
                this.Visible = false;
            }
        }
    }
}
