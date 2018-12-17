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
    public partial class ChangePassword : Form
    {
        Employee em;
        public ChangePassword(Employee em)
        {
            InitializeComponent();
            this.em = em;
            hiddenErr();
            txtUsername.Text = em.username;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(em.password))
            {
               
                hiddenErr();
                lb1.Visible = true;
                return;
            }
            if (txtNewPassword.Text.Equals(""))
            {

                hiddenErr();
                lb2.Visible = true;
                return;
            }
            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {

                hiddenErr();
                lb3.Visible = true;
                return;
            }
            EmployeeDAO dao = new EmployeeDAO();
            dao.UpdatePassowrd(em.username, txtNewPassword.Text);

            MessageBox.Show("Change Successful. \nApplication will be closed.Please login again!","Message");
            Application.Exit();
        }
        private void hiddenErr()
        {
            lb1.Visible = false;
            lb2.Visible = false;

            lb3.Visible = false;
        }

      
    }
}
