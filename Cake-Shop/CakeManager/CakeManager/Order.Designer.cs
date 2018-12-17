namespace CakeManager
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.userControl11 = new CakeManager.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "Id";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(284, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 20);
            this.txtSearch.TabIndex = 75;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(476, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 32);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReject
            // 
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Image = ((System.Drawing.Image)(resources.GetObject("btnReject.Image")));
            this.btnReject.Location = new System.Drawing.Point(721, 427);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 100);
            this.btnReject.TabIndex = 73;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(215, 299);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(44, 35);
            this.btnLoad.TabIndex = 71;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(707, 387);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(341, 20);
            this.txtPhone.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(268, 388);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(353, 20);
            this.txtAddress.TabIndex = 63;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(707, 347);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(341, 20);
            this.txtCustomerId.TabIndex = 62;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(268, 352);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(353, 20);
            this.txtOrderId.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Order ID";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(215, 43);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(442, 242);
            this.dgvOrder.TabIndex = 56;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(663, 43);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(383, 242);
            this.dgvOrderDetail.TabIndex = 85;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.Location = new System.Drawing.Point(357, 427);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(115, 100);
            this.btnAccept.TabIndex = 86;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-3, 2);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(181, 567);
            this.userControl11.TabIndex = 87;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnAccept;
        private UserControl1 userControl11;
    }
}