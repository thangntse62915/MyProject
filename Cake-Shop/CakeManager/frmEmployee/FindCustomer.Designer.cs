namespace frmEmployee
{
    partial class FindCustomer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.btnGetId = new System.Windows.Forms.Button();
            this.btnClosed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(136, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(358, 40);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 1;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // gvCustomer
            // 
            this.gvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Location = new System.Drawing.Point(42, 128);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.Size = new System.Drawing.Size(445, 283);
            this.gvCustomer.TabIndex = 3;
            // 
            // btnGetId
            // 
            this.btnGetId.Location = new System.Drawing.Point(518, 197);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(95, 23);
            this.btnGetId.TabIndex = 4;
            this.btnGetId.Text = "Get Customer";
            this.btnGetId.UseVisualStyleBackColor = true;
            this.btnGetId.Click += new System.EventHandler(this.btnGetId_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(518, 388);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(95, 23);
            this.btnClosed.TabIndex = 5;
            this.btnClosed.Text = "Close";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // FindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnGetId);
            this.Controls.Add(this.gvCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindCustomer";
       
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCustomer;
        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.Button btnClosed;
    }
}