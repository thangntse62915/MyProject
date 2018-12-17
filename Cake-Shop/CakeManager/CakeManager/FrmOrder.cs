using DAOLibrary;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CakeManager
{
    public partial class FrmOrder : Form
    {
        OrderDAO orderDAO;
        OrderDetailDAO orderDetailDAO;
        public FrmOrder()
        {
            InitializeComponent();
        }
        private void hideOrderColumn()
        {
            dgvOrder.Columns["tblCustomer"].Visible = false;
            dgvOrder.Columns["tblOrderDetails"].Visible = false;
        }
        private void hideOrderDetailColumn()
        {
            dgvOrderDetail.Columns["tblCake"].Visible = false;
            dgvOrderDetail.Columns["tblOrder"].Visible = false;
        }
        private void clearTextBoxBinding()
        {
            txtOrderId.DataBindings.Clear();
            txtCustomerId.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtPhone.DataBindings.Clear();

        }
        private void bindingTextBoxData(IEnumerable dataTable)
        {
            txtCustomerId.DataBindings.Add("Text", dataTable, "CusId");
            txtAddress.DataBindings.Add("Text", dataTable, "Address");
            txtPhone.DataBindings.Add("Text", dataTable, "Phone");
            txtOrderId.DataBindings.Add("Text", dataTable, "orderId");
        }
        private void Order_Load(object sender, EventArgs e)
        {
            orderDAO = new OrderDAO();
            orderDetailDAO = new OrderDetailDAO();
            btnLoad_Click(null, null);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbxUnhandle.Checked)
            {
                clearTextBoxBinding();
                var c = orderDAO.GetAllUnhandleOrder();
                dgvOrder.DataSource = c;
                bindingTextBoxData(c);
                dgvOrderDetail.DataSource = null;
            }
            else
            {
                clearTextBoxBinding();
                var c = orderDAO.GetAllOrder();
                dgvOrder.DataSource = c;
                bindingTextBoxData(c);
                dgvOrderDetail.DataSource = null;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var c = orderDetailDAO.GetOrderDetail(int.Parse(txtOrderId.Text));
            dgvOrderDetail.DataSource = c;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (orderDAO.AcceptOrder(int.Parse(txtOrderId.Text)))
            {
                MessageBox.Show("Accept success");
            }
            else
            {
                MessageBox.Show("already handled");
            }
            btnLoad_Click(null, null);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            if (orderDAO.RejectOrder(int.Parse(txtOrderId.Text)))
            {
                MessageBox.Show("Reject success");
            }
            else
            {
                MessageBox.Show("already handled");
            }
            btnLoad_Click(null, null);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clearTextBoxBinding();
                var c = orderDAO.SearchOrder(int.Parse(txtSearch.Text));
                dgvOrder.DataSource = c;
                bindingTextBoxData(c);
                dgvOrderDetail.DataSource = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Id must be a Integer");
            }
        }

        private void dgvOrder_DataSourceChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).DataSource != null)
            {
                hideOrderColumn();
            }

        }

        private void dgvOrderDetail_DataSourceChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).DataSource != null)
            {
                hideOrderDetailColumn();
            }
        }
    }
}
