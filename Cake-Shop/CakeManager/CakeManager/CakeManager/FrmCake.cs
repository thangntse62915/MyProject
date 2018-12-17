using DAOs;
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

namespace CakeManager
{
    public partial class FrmCake : Form
    {
        CakeDAO Cakedao = new CakeDAO();
        CategoryDAO CateDAO = new CategoryDAO();
        Data.Cake err = new Data.Cake();
        List<Data.Category> listCtg;
        DataTable dt;
        public FrmCake()
        {
            InitializeComponent();
           
     
            listCtg = CateDAO.getListCategory();
            txtCategory.DataSource = listCtg;
            txtCategory.DisplayMember = "name";
            txtCategory.ValueMember = "id";
            txtCategory.SelectedIndex = 0;
            getCakes();

        }
        public void getCakes()
        {
            dt = Cakedao.getCakes();
            bindS.DataSource = dt;
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtOrigin.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
            pBox1.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindS, "CakeId");
            txtName.DataBindings.Add("Text", bindS, "name");
            txtOrigin.DataBindings.Add("Text", bindS, "origin");
            txtPrice.DataBindings.Add("Text", bindS, "price");
            txtQuantity.DataBindings.Add("Text", bindS, "quantity");
            pBox1.DataBindings.Add("image", bindS, "img1", true);
            txtCategory.DataBindings.Add("text", bindS, "categoryName");
            tblCake.DataSource = bindS;
            bindNav.BindingSource = bindS;
            tblCake.Columns["img1"].Visible = false;
            tblCake.Columns["categoryId"].Visible = false;
            tblCake.Columns["status"].Visible = false;



        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = openfile.Filter = "JPG file (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pBox1.ImageLocation = openfile.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
           
            txtCategory.Text = "";
            txtName.Text = "";
            txtOrigin.Text = "";
            txtQuantity.Text = "0";
            txtQuantity.DataBindings.Clear();
            txtPrice.Text = "0";
            txtPrice.DataBindings.Clear();
            txtID.Enabled = true;
            txtCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data.Cake c = GetCake();
            if (c == null) return;
            if(c.Img1 == null)
            {
                MessageBox.Show("Please choo a picture");
                return;
            }
            try { bool result = Cakedao.AddNewCake(c);
                if(result == true)
                {
                    MessageBox.Show("Add successfull");
                    getCakes();
                }
                
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate"))
                    MessageBox.Show("ID is exist");
            }


        }
        public Data.Cake GetCake()
        {
            string id = txtID.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("Id is not blank");
                return null;
            }
            string name = txtName.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Cake Name is not blank");
                return null;
            }

            string category = txtCategory.SelectedItem.ToString();

            MessageBox.Show("cate" + category);

            string origin = txtOrigin.Text;
            if (origin.Length == 0)
            {
                MessageBox.Show("Cake Origin is not blank");
                return null;
            }
            float price;
            try
            {
                price = float.Parse(txtPrice.Text);
                if (price <= 0)
                {
                    MessageBox.Show("Price must > 0");
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Price is a number");
                return null;
            }
            int quantity;
            try
            {
                quantity = int.Parse(txtQuantity.Text);
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity must >= 0");
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Quantity is a number");
                return null;
            }

           
                MessageBox.Show(pBox1.ImageLocation);
            
            byte[] img1 = null;
            if (pBox1.ImageLocation != null)
            {
                img1 = convertImageToBytes(pBox1.ImageLocation);
            }

            string description = txtDescription.Text;

            Data.Cake c = new Data.Cake(id, name, price, origin, quantity, img1, category, description);
            return c;
        }
        public byte[] convertImageToBytes(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] result = new byte[fs.Length];
            fs.Read(result, 0, Convert.ToInt32(fs.Length));

            fs.Close();
            return result;
        }

      private void btnUpdate_Click(object sender, EventArgs e)
        {
            Data.Cake c = GetCake();
          
            if(c.Img1 == null)
            {
                MessageBox.Show("null");
                Cakedao.UpdateCakeNoImg(c);
            }
            else { Cakedao.UpdateCake(c); MessageBox.Show("nkoull"); }
            MessageBox.Show("Update Successfull");
            getCakes();

        }

        
        private void tblCake_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Enabled = false;
            bindS.DataSource = dt;
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtOrigin.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
            pBox1.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindS, "CakeId");
            txtName.DataBindings.Add("Text", bindS, "name");
            txtOrigin.DataBindings.Add("Text", bindS, "origin");
            txtPrice.DataBindings.Add("Text", bindS, "price");
            txtQuantity.DataBindings.Add("Text", bindS, "quantity");
            pBox1.DataBindings.Add("image", bindS, "img1", true);
            pBox1.ImageLocation = null;
            txtCategory.DataBindings.Add("text", bindS, "categoryName");
            tblCake.DataSource = bindS;
            bindNav.BindingSource = bindS;
            tblCake.Columns["img1"].Visible = false;
            tblCake.Columns["categoryId"].Visible = false;
            tblCake.Columns["status"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            Boolean result = Cakedao.DeleteCake(id);
            if(result == true)
            {
                MessageBox.Show("Delete Successfull");
            }
            else
            {
                MessageBox.Show("Delete Fail with CakeID = " +  id);
            }
        }
    }
}
