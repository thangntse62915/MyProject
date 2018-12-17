using DAOLibrary;
using System;
using System.Collections;
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
    public partial class FrmEmployee : Form
    {

        EmployeeDAO dao = new EmployeeDAO();
        IEnumerable dt;
        public FrmEmployee()
        {
            InitializeComponent();
            List<String> Gender = new List<String>();
            Gender.Add("Male");
            Gender.Add("Female");
            txtGender.DataSource = Gender;
            dt = dao.GetAllEmployyee();
            bindSource.DataSource = dt;
            tblEmployee.DataSource = bindSource;
            bindNav.BindingSource = bindSource;
            Binding(bindSource);
            hiddencloumn();
            txtUsername.Enabled = false;
        }
        public void hiddencloumn() {
            tblEmployee.Columns["password"].Visible = false;
            tblEmployee.Columns["image"].Visible = false;
            tblEmployee.Columns["address"].Visible = false;
            tblEmployee.Columns["gender"].Visible = false;
            tblEmployee.Columns["status"].Visible = false;
            tblEmployee.Columns["role"].Visible = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBirthday.Text = DateTime.Now.ToString();
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCard.Text = "";
            txtUsername.Enabled = true;
            ClearBinding();
            txtGender.SelectedIndex = 0;

         
        }
        public void ClearBinding()
        {
            txtName.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtBirthday.DataBindings.Clear();
            txtCard.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtGender.DataBindings.Clear();
            pBox1.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
        }
        public void Binding(IEnumerable dt)
        {
            
            txtName.DataBindings.Add("text", dt, "Name");
            txtAddress.DataBindings.Add("text", dt, "Address");
            txtBirthday.DataBindings.Add("text", dt, "birthday");
            txtCard.DataBindings.Add("text", dt, "Card");
            txtPhone.DataBindings.Add("text", dt, "Phone");
            txtGender.DataBindings.Add("text", dt, "Gender");
            pBox1.DataBindings.Add("image", dt, "image",true);
            txtUsername.DataBindings.Add("text", dt, "username");
            txtPassword.DataBindings.Add("text", dt, "password");
        }
        private Employee GetEmployee()
        {
            Employee employee = new Employee();
            string namex = txtName.Text;
            if (namex.Length == 0)
            {
                MessageBox.Show("Name is not blank");
                return null;
            }
            string birthdayx = txtBirthday.Text;
            string genderx = txtGender.SelectedItem.ToString();
            MessageBox.Show(genderx);
            string phonex = txtPhone.Text;
            if (phonex.Length == 0)
            {
                MessageBox.Show("PhoneNumber is not blank");
                return null;
            }
            string addressx = txtAddress.Text;
            if (addressx.Length == 0)
            {
                MessageBox.Show("Address is not blank");
                return null;
            }
            string cardx = txtCard.Text;
            if (cardx.Length == 0)
            {
                MessageBox.Show("CardNumber is not blank");
                return null;
            }
            byte[] imgx = null;
            if (pBox1.ImageLocation != null)
            {
                imgx = convertImageToBytes(pBox1.ImageLocation);
            }
            string username = txtUsername.Text;
            if (username.Length == 0)
            {
                MessageBox.Show("Username is not blank");
                return null;
            }
            string password = txtPassword.Text;
            if (password.Length == 0)
            {
                MessageBox.Show("Password is not blank");
                return null;
            }
            employee.name = namex;
            employee.birthday = DateTime.Parse(birthdayx);
            employee.phone = phonex;
            employee.gender = genderx;
            employee.Card = cardx;
            employee.address = addressx;
            employee.Image = imgx;
            employee.username = username;
            employee.password = password;
            employee.status = true;
            return employee;

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
            Employee em = GetEmployee();
            int id = Convert.ToInt32(tblEmployee.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            dao.UpdateEmployy(em, id);
            dt = dao.GetAllEmployyee();
            ClearBinding();
            bindSource.DataSource = dt;
            tblEmployee.DataSource = bindSource;
            bindNav.BindingSource = bindSource;
            Binding(bindSource);
            MessageBox.Show("Update successful");
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee em = GetEmployee();
            int id = Convert.ToInt32(tblEmployee.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
    
            dao.DeleteEmployee(id);
            dt = dao.GetAllEmployyee();
            ClearBinding();
            bindSource.DataSource = dt;
            tblEmployee.DataSource = bindSource;
            bindNav.BindingSource = bindSource;
            Binding(bindSource); MessageBox.Show("Delete successful");
        }
    

        private void tblEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Enabled = false;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Employee em = GetEmployee();
            em.role = "Employee";
            if (em != null)
            {
                if (em.Image == null)
                {
                    MessageBox.Show("Choose Image for employee");
                    return;

                }
                try
                {
                    dao.AddEmployee(em);
                    dt = dao.GetAllEmployyee();
                    ClearBinding();
                    bindSource.DataSource = dt;
                    tblEmployee.DataSource = bindSource;
                    bindNav.BindingSource = bindSource;
                    Binding(bindSource);
                    MessageBox.Show("Add successful");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                       return;
                    

                }
                
                
            }

        }

        private void btnChoose_Click_1(object sender, EventArgs e)
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

      

        private void tblEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            dt = dao.SearchEmployee(searchValue);
            ClearBinding();
            bindSource.DataSource = dt;
            tblEmployee.DataSource = bindSource;
            bindNav.BindingSource = bindSource;
            Binding(bindSource);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            ClearBinding();
            dt = dao.GetAllEmployyee();
            bindSource.DataSource = dt;
            tblEmployee.DataSource = bindSource;
            bindNav.BindingSource = bindSource;
            Binding(bindSource);
            hiddencloumn();
            txtUsername.Enabled = false;
        }
    }
}

