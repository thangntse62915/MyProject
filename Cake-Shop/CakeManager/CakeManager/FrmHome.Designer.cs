namespace CakeManager
{
    partial class FrmHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.navigatorControl1 = new CakeManager.NavigatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1377, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 68);
            this.panel2.TabIndex = 1;
            // 
            // navigatorControl1
            // 
            this.navigatorControl1.Location = new System.Drawing.Point(1, 4);
            this.navigatorControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navigatorControl1.Name = "navigatorControl1";
            this.navigatorControl1.Size = new System.Drawing.Size(240, 832);
            this.navigatorControl1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 135);
            this.label1.TabIndex = 41;
            this.label1.Text = "Welcome to Bakery";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1656, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navigatorControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private NavigatorControl navigatorControl1;
        private System.Windows.Forms.Label label1;
    }
}