namespace frmEmployee
{
    partial class CreateCustomer
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
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "yyyy-MM-dd";
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthday.Location = new System.Drawing.Point(140, 148);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(218, 20);
            this.txtBirthday.TabIndex = 97;
            this.txtBirthday.Value = new System.DateTime(2018, 10, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 89;
            this.label4.Text = "FullName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 87;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "CUSTOMER INFORMATION";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(282, 331);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 23);
            this.btnCreate.TabIndex = 99;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(100, 331);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 23);
            this.btnNew.TabIndex = 100;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 101;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(218, 20);
            this.txtId.TabIndex = 106;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 247);
            this.txtPhone.Mask = "0000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 20);
            this.txtPhone.TabIndex = 107;
            this.txtPhone.ValidatingType = typeof(int);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 383);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}