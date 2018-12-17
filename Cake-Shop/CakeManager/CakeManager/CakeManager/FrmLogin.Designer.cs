namespace CakeManager
{
    partial class FrmLogin
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClear.Location = new System.Drawing.Point(118, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogin.Location = new System.Drawing.Point(298, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(188, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "LOGIN";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(184, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 356);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
    }
}

