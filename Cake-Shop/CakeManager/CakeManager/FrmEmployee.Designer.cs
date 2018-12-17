namespace CakeManager
{
    partial class FrmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.bindSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtCard = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.bindNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tblEmployee = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.navigatorControl1 = new CakeManager.NavigatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNav)).BeginInit();
            this.bindNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(746, 553);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 117;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click_1);
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(300, 482);
            this.txtCard.Mask = "0000000000";
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(120, 20);
            this.txtCard.TabIndex = 116;
            this.txtCard.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 115;
            this.label3.Text = "Identity Card";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(300, 527);
            this.txtPhone.Mask = "0000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 114;
            this.txtPhone.ValidatingType = typeof(int);
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "yyyy-MM-dd";
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthday.Location = new System.Drawing.Point(492, 374);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(84, 20);
            this.txtBirthday.TabIndex = 113;
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(1014, 336);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 52);
            this.btnNew.TabIndex = 110;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(1070, 39);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 112;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // bindNav
            // 
            this.bindNav.AddNewItem = null;
            this.bindNav.CountItem = this.bindingNavigatorCountItem;
            this.bindNav.DeleteItem = null;
            this.bindNav.Dock = System.Windows.Forms.DockStyle.None;
            this.bindNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindNav.Location = new System.Drawing.Point(571, 300);
            this.bindNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNav.Name = "bindNav";
            this.bindNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNav.Size = new System.Drawing.Size(207, 27);
            this.bindNav.TabIndex = 111;
            this.bindNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // pBox1
            // 
            this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
            this.pBox1.Location = new System.Drawing.Point(704, 336);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(180, 211);
            this.pBox1.TabIndex = 109;
            this.pBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 108;
            this.label9.Text = "Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(373, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 20);
            this.txtSearch.TabIndex = 107;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(580, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 32);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1095, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 52);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1095, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 52);
            this.btnAdd.TabIndex = 104;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1014, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 52);
            this.btnUpdate.TabIndex = 103;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(492, 482);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 20);
            this.txtAddress.TabIndex = 102;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Location = new System.Drawing.Point(300, 373);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(120, 21);
            this.txtGender.TabIndex = 99;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(300, 336);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 98;
            // 
            // tblEmployee
            // 
            this.tblEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEmployee.Location = new System.Drawing.Point(241, 39);
            this.tblEmployee.Name = "tblEmployee";
            this.tblEmployee.Size = new System.Drawing.Size(823, 260);
            this.tblEmployee.TabIndex = 94;
            this.tblEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblEmployee_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 101;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Name";
            // 
            // zs
            // 
            this.zs.AutoSize = true;
            this.zs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zs.Location = new System.Drawing.Point(207, 374);
            this.zs.Name = "zs";
            this.zs.Size = new System.Drawing.Size(54, 15);
            this.zs.TabIndex = 96;
            this.zs.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 118;
            this.label1.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 119;
            this.label7.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(300, 431);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 120;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(502, 431);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 121;
            // 
            // navigatorControl1
            // 
            this.navigatorControl1.Location = new System.Drawing.Point(-1, 4);
            this.navigatorControl1.Name = "navigatorControl1";
            this.navigatorControl1.Size = new System.Drawing.Size(180, 683);
            this.navigatorControl1.TabIndex = 122;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1302, 606);
            this.Controls.Add(this.navigatorControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.bindNav);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.tblEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zs);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "News";
            ((System.ComponentModel.ISupportInitialize)(this.bindSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNav)).EndInit();
            this.bindNav.ResumeLayout(false);
            this.bindNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSource;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MaskedTextBox txtCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.BindingNavigator bindNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView tblEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label zs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private NavigatorControl navigatorControl1;
    }
}