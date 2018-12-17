namespace frmEmployee
{
    partial class ChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(187, 211);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(34, 211);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(105, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(102, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(102, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(105, 133);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(102, 20);
            this.txtNewPassword.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(105, 168);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(102, 20);
            this.txtConfirmPassword.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, -136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "CHANGE INFORMATION";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb1.Location = new System.Drawing.Point(213, 103);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 13);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "Password is not valid";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb2.Location = new System.Drawing.Point(213, 140);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(111, 13);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "Password Is not blank";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb3.Location = new System.Drawing.Point(209, 171);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(115, 13);
            this.lb3.TabIndex = 14;
            this.lb3.Text = "Password must confirm";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInformationEm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
    }
}