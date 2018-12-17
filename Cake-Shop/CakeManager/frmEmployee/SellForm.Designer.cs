namespace frmEmployee
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VND = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtCakeName = new System.Windows.Forms.TextBox();
            this.gvCake = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.InsertCake = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCreOrder = new System.Windows.Forms.Button();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.fs = new System.Windows.Forms.Label();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.picEm = new System.Windows.Forms.PictureBox();
            this.lbEm = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCake)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VND);
            this.panel1.Controls.Add(this.cbTitle);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.txtCakeName);
            this.panel1.Controls.Add(this.gvCake);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 407);
            this.panel1.TabIndex = 0;
            // 
            // VND
            // 
            this.VND.AutoSize = true;
            this.VND.Location = new System.Drawing.Point(451, 261);
            this.VND.Name = "VND";
            this.VND.Size = new System.Drawing.Size(30, 13);
            this.VND.TabIndex = 8;
            this.VND.Text = "VND";
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(38, 30);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(69, 21);
            this.cbTitle.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(346, 254);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(106, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(352, 98);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 103);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // txtCakeName
            // 
            this.txtCakeName.Enabled = false;
            this.txtCakeName.Location = new System.Drawing.Point(333, 222);
            this.txtCakeName.Name = "txtCakeName";
            this.txtCakeName.Size = new System.Drawing.Size(142, 20);
            this.txtCakeName.TabIndex = 1;
            this.txtCakeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gvCake
            // 
            this.gvCake.AllowUserToAddRows = false;
            this.gvCake.AllowUserToDeleteRows = false;
            this.gvCake.AllowUserToOrderColumns = true;
            this.gvCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCake.Location = new System.Drawing.Point(38, 98);
            this.gvCake.Name = "gvCake";
            this.gvCake.ReadOnly = true;
            this.gvCake.Size = new System.Drawing.Size(279, 283);
            this.gvCake.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(324, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // InsertCake
            // 
            this.InsertCake.Location = new System.Drawing.Point(537, 258);
            this.InsertCake.Name = "InsertCake";
            this.InsertCake.Size = new System.Drawing.Size(94, 23);
            this.InsertCake.TabIndex = 1;
            this.InsertCake.Text = "Add";
            this.InsertCake.UseVisualStyleBackColor = true;
            this.InsertCake.Click += new System.EventHandler(this.InsertCake_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.btnCreOrder);
            this.panel2.Controls.Add(this.gvOrder);
            this.panel2.Controls.Add(this.fs);
            this.panel2.Controls.Add(this.txtCusId);
            this.panel2.Location = new System.Drawing.Point(666, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 407);
            this.panel2.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(284, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 26);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find Cuxtomer";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(331, 372);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(69, 13);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "Total: 0 VND";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(147, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(228, 362);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(83, 26);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCreOrder
            // 
            this.btnCreOrder.Location = new System.Drawing.Point(49, 365);
            this.btnCreOrder.Name = "btnCreOrder";
            this.btnCreOrder.Size = new System.Drawing.Size(83, 26);
            this.btnCreOrder.TabIndex = 9;
            this.btnCreOrder.Text = "New Order";
            this.btnCreOrder.UseVisualStyleBackColor = true;
            this.btnCreOrder.Click += new System.EventHandler(this.btnCreOrder_Click);
            // 
            // gvOrder
            // 
            this.gvOrder.AllowUserToAddRows = false;
            this.gvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Location = new System.Drawing.Point(49, 76);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(390, 283);
            this.gvOrder.TabIndex = 3;
            this.gvOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrder_CellEndEdit);
            this.gvOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvOrder_DataError);
            // 
            // fs
            // 
            this.fs.AutoSize = true;
            this.fs.Location = new System.Drawing.Point(11, 36);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(62, 13);
            this.fs.TabIndex = 1;
            this.fs.Text = "CustomerID";
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(79, 33);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(143, 20);
            this.txtCusId.TabIndex = 0;
            // 
            // picEm
            // 
            this.picEm.Location = new System.Drawing.Point(715, 12);
            this.picEm.Name = "picEm";
            this.picEm.Size = new System.Drawing.Size(78, 75);
            this.picEm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEm.TabIndex = 8;
            this.picEm.TabStop = false;
            // 
            // lbEm
            // 
            this.lbEm.AutoSize = true;
            this.lbEm.Location = new System.Drawing.Point(832, 19);
            this.lbEm.Name = "lbEm";
            this.lbEm.Size = new System.Drawing.Size(35, 13);
            this.lbEm.TabIndex = 7;
            this.lbEm.Text = "label3";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1055, 55);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bakery Shop";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(813, 55);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(111, 23);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(930, 55);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1154, 532);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbEm);
            this.Controls.Add(this.picEm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.InsertCake);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCake)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtCakeName;
        private System.Windows.Forms.DataGridView gvCake;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button InsertCake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCreOrder;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.Label fs;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.PictureBox picEm;
        private System.Windows.Forms.Label lbEm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label VND;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreate;
    }
}

