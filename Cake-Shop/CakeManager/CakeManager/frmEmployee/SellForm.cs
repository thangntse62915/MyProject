using DAOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEmployee
{
    public partial class SellForm : Form
    {
        IEnumerable<tblCake> dt;
        List<tblCake> list = new List<tblCake>();
        Employee employee;
        public SellForm()
        {
            InitializeComponent();
            List<String> Title = new List<String>();
            Title.Add("CakeID");
            Title.Add("CakeName");
            cbTitle.DataSource = Title;

        }
        public SellForm(Employee em)
        {
            InitializeComponent();
            List<String> Title = new List<String>();
            Title.Add("CakeID");
            Title.Add("CakeName");
            cbTitle.DataSource = Title;
            picEm.Image = Image.FromStream(new MemoryStream(em.Image));
            lbEm.Text = em.name;
            employee = em;

        }
        private void BindingData()
        {
            txtCakeName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            picBox.DataBindings.Clear();
            txtCakeName.DataBindings.Add("Text", dt, "name");
            txtPrice.DataBindings.Add("Text", dt, "price");
            picBox.DataBindings.Add("image", dt, "img1", true);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CakeDAO CDAO = new CakeDAO();
            string Value = txtSearch.Text;
            string TypeSearch = cbTitle.SelectedItem.ToString();

            if (TypeSearch.Equals("CakeName"))
            {
                dt = CDAO.SearchCake(Value, false);
            }
            else
            {
                dt = CDAO.SearchCake(Value, true);
            }
            gvCake.DataSource = dt;
            hiddenColumn();
            BindingData();

        }
        private void hiddenColumn()
        {
            gvCake.Columns["cakeId"].HeaderText = "ID";
            gvCake.Columns["name"].HeaderText = "Name";
            gvCake.Columns["price"].HeaderText = "Price";
            gvCake.Columns["origin"].Visible = false;
            gvCake.Columns["img1"].Visible = false;
            gvCake.Columns["tblOrderDetails"].Visible = false;
            gvCake.Columns["bought"].Visible = false;
            gvCake.Columns["quantity"].Visible = false;
            gvCake.Columns["categoryid"].Visible = false;
            gvCake.Columns["description"].Visible = false;
            gvCake.Columns["status"].Visible = false;
            gvCake.Columns["tblCategory"].Visible = false;


        }

        private void InsertCake_Click(object sender, EventArgs e)
        {if(dt == null|| dt.Count() == 0)
            {
                MessageBox.Show("Search Cake First");
                return;
            }
            string id = gvCake.SelectedCells[0].OwningRow.Cells["cakeId"].Value.ToString();
            string Nname = gvCake.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
            float Nprice = float.Parse(gvCake.SelectedCells[0].OwningRow.Cells["price"].Value.ToString());


            tblCake c = list.Where(x => x.cakeId.Equals(id)).SingleOrDefault();
            if (c == null)
            {
                list.Add(new tblCake { cakeId = id, name = Nname, price = Nprice, quantity = 1 });
            }
            else
            {
                c.quantity += 1;
            }

            gvOrder.DataSource = null;
            gvOrder.DataSource = list;
            lbTotal.Text = "Total: " + list.Sum(x => x.price * x.quantity) + " VND";
            hiddenOrder();
        }
        private void hiddenOrder()
        {
            gvOrder.Columns["cakeId"].HeaderText = "ID";
            gvOrder.Columns["name"].HeaderText = "Name";
            gvOrder.Columns["price"].HeaderText = "Price";
            gvOrder.Columns["origin"].Visible = false;
            gvOrder.Columns["img1"].Visible = false;
            gvOrder.Columns["tblOrderDetails"].Visible = false;
            gvOrder.Columns["bought"].Visible = false;
            gvOrder.Columns["categoryid"].Visible = false;
            gvOrder.Columns["description"].Visible = false;
            gvOrder.Columns["status"].Visible = false;
            gvOrder.Columns["tblCategory"].Visible = false;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            OrderDAO dao = new OrderDAO();
            if(list.Count == 0)
            {
                MessageBox.Show("Add Cake First!!!!!");
                return;
            }
            string result = dao.createOrder(txtCusId.Text, list);
            if (result.Equals("")) {
                btnCreOrder_Click(null, null);
                MessageBox.Show("Accept Successful");
            }
            else
            {
                MessageBox.Show("Customer is not exist");
            }



        }

        private void btnCreOrder_Click(object sender, EventArgs e)
        {
            list = new List<tblCake>();
            gvOrder.DataSource = null;
            lbTotal.Text = "Total: " + list.Sum(x => x.price * x.quantity) + " VND";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {if (list.Count == 0) return;
            string id = gvOrder.SelectedCells[0].OwningRow.Cells["cakeId"].Value.ToString();
            list.Remove(list.Where(x => x.cakeId.Equals(id)).SingleOrDefault());
            gvOrder.DataSource = null;
            gvOrder.DataSource = list;
            hiddenOrder();
            lbTotal.Text = "Total: " + list.Sum(x => x.price * x.quantity) + " VND";
        }



        private void gvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lbTotal.Text = "Total: " + list.Sum(c => c.price * c.quantity) + " VND";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            new FindCustomer(this).Visible = true;
        }
        public void getId(string id)
        {txtCusId.Text =  id;

        }

        private void SellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void gvOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePassword(employee).Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateCustomer().Visible = true;
        }
    }
}

