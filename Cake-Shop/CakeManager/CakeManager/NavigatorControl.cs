using Session;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CakeManager
{
    public partial class NavigatorControl : UserControl
    {
        private static readonly Color selectColor = Color.PeachPuff;
        private static readonly Color deselectColor = Color.RosyBrown;
        public NavigatorControl()
        {
            InitializeComponent();
        }
        private void DeselectAllButton()
        {
            btnCake.BackColor = deselectColor;
            btnCustomer.BackColor = deselectColor;
            btnEmployee.BackColor = deselectColor;
            btnHome.BackColor = deselectColor;
            btnOrder.BackColor = deselectColor;
        }
        private void ChangeForm(object sender)
        {
            if (sender is Button)
            {
                Parent.Hide();
                Form f = new CurrentSession().FormDictionary["Frm" + (sender as Button).Text];
                f.Show();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeForm(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ChangeForm(sender);
        }

        private void btnCake_Click(object sender, EventArgs e)
        {
            ChangeForm(sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ChangeForm(sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ChangeForm(sender);
        }

        private void NavigatorControl_Load(object sender, EventArgs e)
        {
            if (Parent is FrmCake)
            {
                btnCake.BackColor = selectColor;
            }
            if (Parent is FrmCustomer)
            {
                btnCustomer.BackColor = selectColor;
            }
            if (Parent is FrmEmployee)
            {
                btnEmployee.BackColor = selectColor;
            }
            if (Parent is FrmHome)
            {
                btnHome.BackColor = selectColor;
            }
            if (Parent is FrmOrder)
            {
                btnOrder.BackColor = selectColor;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentSession cs = new CurrentSession();
            cs.InitSession();
            Application.Restart();
        }
    }
}
