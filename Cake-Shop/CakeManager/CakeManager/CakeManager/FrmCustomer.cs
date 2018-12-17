using DAOLibrary;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CakeManager
{
    public partial class FrmCustomer : Form
    {
        CustomerDAO dao = new CustomerDAO();
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void clearTextBoxBinding()
        {
            txtCustomerId.DataBindings.Clear();
            txtFullname.DataBindings.Clear();
            txtBirthday.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

        }
        private void bindingTextBoxData(IEnumerable dataTable)
        {
            txtCustomerId.DataBindings.Add("Text", dataTable, "CustomerId");
            txtFullname.DataBindings.Add("Text", dataTable, "Fullname");
            txtBirthday.DataBindings.Add("Text", dataTable, "Birthday");
            txtAddress.DataBindings.Add("Text", dataTable, "Address");
            txtPhone.DataBindings.Add("Text", dataTable, "Phone");
            txtEmail.DataBindings.Add("Text", dataTable, "Email");
        }
        private void hideColumn()
        {
            dgvCustomer.Columns["tblOrders"].Visible = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            clearTextBoxBinding();
            var c = dao.GetAllCustomer();
            dgvCustomer.DataSource = c;
            bindingTextBoxData(c);
            hideColumn();
        }

        private void FrmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (dao.BanCustomer(txtCustomerId.Text))
            {
                MessageBox.Show("Ban success");
            }
            else
            {
                MessageBox.Show("already banned");
            }
            btnLoad_Click(null, null);
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            if (dao.UnbanCustomer(txtCustomerId.Text))
            {
                MessageBox.Show("Unban success");
            }
            else
            {
                MessageBox.Show("already unbanned");
            }
            btnLoad_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearTextBoxBinding();
            var c = dao.SearchCustomer(txtSearch.Text);
            dgvCustomer.DataSource = c;
            bindingTextBoxData(c);
            hideColumn();
        }
    }
}
