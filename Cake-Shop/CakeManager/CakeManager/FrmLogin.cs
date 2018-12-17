using DAOLibrary;
using Session;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CakeManager
{
    public partial class FrmLogin : Form
    {
        EmployeeDAO dao = new EmployeeDAO();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Employee em = dao.checkAdminLogin(username, password);
            if (em == null)
            {
                MessageBox.Show("Username or password is not valid");
                return;
            }
            else if (em.role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                InitFormCollection();
                new CurrentSession().FormDictionary["FrmHome"].Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You do not have enough permission");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        public void InitFormCollection()
        {
            CurrentSession current = new CurrentSession();
            Dictionary<string, Form> formDictionary = current.FormDictionary;
            List<Form> formList = new List<Form>();
            formList.Add(this);
            formList.Add(new FrmCake());
            formList.Add(new FrmCustomer());
            formList.Add(new FrmHome());
            formList.Add(new FrmEmployee());
            formList.Add(new FrmOrder());
            foreach (var item in formList)
            {
                formDictionary.Add(item.GetType().Name, item);
                item.FormClosing += Item_FormClosing;
            }

            //formDictionary.Add(typeof(FrmLogin).Name, this);
            //formDictionary.Add(typeof(FrmCake).Name, new FrmCake());
            //formDictionary.Add(typeof(FrmCustomer).Name, new FrmCustomer());
            //formDictionary.Add(typeof(FrmHome).Name, new FrmHome());
            //formDictionary.Add(typeof(FrmEmployee).Name, new FrmEmployee());
            //formDictionary.Add(typeof(FrmOrder).Name, new FrmOrder());
        }

        private void Item_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
