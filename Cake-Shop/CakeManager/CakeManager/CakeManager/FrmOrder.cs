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
            clearTextBoxBinding();
            var c = orderDAO.GetAllOrder();
            dgvOrder.DataSource = c;
            bindingTextBoxData(c);
            dgvOrderDetail.DataSource = null;
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var c = orderDetailDAO.GetOrderDetail(int.Parse(txtOrderId.Text));
            dgvOrderDetail.DataSource = c;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (orderDAO.AcceptOrder(txtOrderId.Text))
            {
                MessageBox.Show("Accept success");
            }
            else
            {
                MessageBox.Show("already Accepted");
            }
            btnLoad_Click(null, null);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (orderDAO.RejectOrder(txtOrderId.Text))
            {
                MessageBox.Show("Reject success");
            }
            else
            {
                MessageBox.Show("already Rejected");
            }
            btnLoad_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearTextBoxBinding();
            var c = orderDAO.SearchOrder(int.Parse(txtOrderId.Text));
            dgvOrder.DataSource = c;
            bindingTextBoxData(c);
            dgvOrderDetail.DataSource = null;
        }
    }
}
