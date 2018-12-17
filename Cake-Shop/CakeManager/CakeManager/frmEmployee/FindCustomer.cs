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
    public partial class FindCustomer : Form
    {
        SellForm form;
        IEnumerable<tblCustomer> dt = null;
        public FindCustomer()
        {
            InitializeComponent();
        }
        public FindCustomer(SellForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            if (dt == null|| dt.Count() == 0)
            {
                MessageBox.Show("Search customer first");
                return;
            }
            String id = gvCustomer.SelectedCells[0].OwningRow.Cells["customerid"].Value.ToString();
            form.getId(id);
            this.Close();

        }
        public void hiddenCoulumn()
        {
            gvCustomer.Columns["customerId"].HeaderText = "ID";
            gvCustomer.Columns["password"].Visible = false;
            gvCustomer.Columns["fullname"].HeaderText = "FullName";
            gvCustomer.Columns["birthday"].Visible = false;
            gvCustomer.Columns["address"].Visible = false;
            gvCustomer.Columns["phone"].HeaderText = "Phonenumber";
            gvCustomer.Columns["email"].Visible = false;
            gvCustomer.Columns["enable"].Visible = false;

            gvCustomer.Columns["tblOrders"].Visible = false;
        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
            CustomerDAO dao = new CustomerDAO();
            string search = txtSearch.Text;
            dt = dao.SearchCustomer(search);
            gvCustomer.DataSource = null;
            gvCustomer.DataSource = dt;
            hiddenCoulumn();


        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
    }
}
