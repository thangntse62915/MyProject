namespace CakeManager
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUnban = new System.Windows.Forms.Button();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.navigatorControl1 = new CakeManager.NavigatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(285, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 20);
            this.txtSearch.TabIndex = 75;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(573, 370);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(573, 408);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(218, 20);
            this.txtEmail.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(268, 410);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(198, 20);
            this.txtPhone.TabIndex = 63;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(573, 336);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(218, 20);
            this.txtFullname.TabIndex = 62;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(268, 337);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(198, 20);
            this.txtCustomerId.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "FullName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(216, 41);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(574, 242);
            this.dgvCustomer.TabIndex = 56;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1042, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 52);
            this.button8.TabIndex = 84;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(478, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 32);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBan
            // 
            this.btnBan.FlatAppearance.BorderSize = 0;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Image = ((System.Drawing.Image)(resources.GetObject("btnBan.Image")));
            this.btnBan.Location = new System.Drawing.Point(355, 470);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(50, 52);
            this.btnBan.TabIndex = 73;
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(218, 289);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(37, 40);
            this.btnLoad.TabIndex = 71;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUnban
            // 
            this.btnUnban.FlatAppearance.BorderSize = 0;
            this.btnUnban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnban.Image = ((System.Drawing.Image)(resources.GetObject("btnUnban.Image")));
            this.btnUnban.Location = new System.Drawing.Point(428, 470);
            this.btnUnban.Name = "btnUnban";
            this.btnUnban.Size = new System.Drawing.Size(50, 52);
            this.btnUnban.TabIndex = 72;
            this.btnUnban.UseVisualStyleBackColor = true;
            this.btnUnban.Click += new System.EventHandler(this.btnUnban_Click);
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "dd/MM/yyyy";
            this.txtBirthday.Enabled = false;
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthday.Location = new System.Drawing.Point(268, 375);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(198, 20);
            this.txtBirthday.TabIndex = 85;
            this.txtBirthday.Value = new System.DateTime(2018, 10, 30, 0, 0, 0, 0);
            // 
            // navigatorControl1
            // 
            this.navigatorControl1.Location = new System.Drawing.Point(2, 6);
            this.navigatorControl1.Margin = new System.Windows.Forms.Padding(4);
            this.navigatorControl1.Name = "navigatorControl1";
            this.navigatorControl1.Size = new System.Drawing.Size(182, 735);
            this.navigatorControl1.TabIndex = 86;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(829, 648);
            this.Controls.Add(this.navigatorControl1);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnUnban);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCustomer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnUnban;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private NavigatorControl navigatorControl1;
    }
}