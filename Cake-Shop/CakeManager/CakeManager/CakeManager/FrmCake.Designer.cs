namespace CakeManager
{
    partial class FrmCake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCake));
            this.tblCake = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnImg1 = new System.Windows.Forms.Button();
            this.bindNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindS = new System.Windows.Forms.BindingSource(this.components);
            this.btnGetAll = new System.Windows.Forms.Button();
            this.navigatorControl1 = new CakeManager.NavigatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.tblCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNav)).BeginInit();
            this.bindNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCake
            // 
            this.tblCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCake.Location = new System.Drawing.Point(210, 39);
            this.tblCake.Name = "tblCake";
            this.tblCake.Size = new System.Drawing.Size(823, 260);
            this.tblCake.TabIndex = 3;
            this.tblCake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblCake_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(268, 338);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(459, 336);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(269, 410);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(269, 373);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(120, 21);
            this.txtCategory.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(459, 409);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(181, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Decription";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(269, 448);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(282, 151);
            this.txtDescription.TabIndex = 17;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(459, 374);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(181, 20);
            this.txtOrigin.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(291, 15);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(181, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(505, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Origin";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(562, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(181, 20);
            this.textBox8.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Quantity";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(838, 11);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(195, 20);
            this.textBox9.TabIndex = 32;
            // 
            // pBox1
            // 
            this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
            this.pBox1.Location = new System.Drawing.Point(683, 340);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(180, 211);
            this.pBox1.TabIndex = 33;
            this.pBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1064, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 32);
            this.button9.TabIndex = 25;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1064, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 52);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1064, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 52);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(983, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 52);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(983, 336);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 52);
            this.btnNew.TabIndex = 54;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnImg1
            // 
            this.btnImg1.Location = new System.Drawing.Point(726, 573);
            this.btnImg1.Name = "btnImg1";
            this.btnImg1.Size = new System.Drawing.Size(63, 26);
            this.btnImg1.TabIndex = 55;
            this.btnImg1.Text = "Choose";
            this.btnImg1.UseVisualStyleBackColor = true;
            this.btnImg1.Click += new System.EventHandler(this.btnImg_Click);
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
            this.bindNav.Location = new System.Drawing.Point(540, 300);
            this.bindNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNav.Name = "bindNav";
            this.bindNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNav.Size = new System.Drawing.Size(207, 27);
            this.bindNav.TabIndex = 56;
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(1064, 44);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 57;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            // 
            // navigatorControl1
            // 
            this.navigatorControl1.Location = new System.Drawing.Point(-2, 2);
            this.navigatorControl1.Name = "navigatorControl1";
            this.navigatorControl1.Size = new System.Drawing.Size(179, 688);
            this.navigatorControl1.TabIndex = 58;
            // 
            // FrmCake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1297, 662);
            this.Controls.Add(this.navigatorControl1);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.bindNav);
            this.Controls.Add(this.btnImg1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblCake);
            this.Name = "FrmCake";
            this.Text = "Cake";
            ((System.ComponentModel.ISupportInitialize)(this.tblCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNav)).EndInit();
            this.bindNav.ResumeLayout(false);
            this.bindNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tblCake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnImg1;
        private System.Windows.Forms.BindingNavigator bindNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bindS;
        private System.Windows.Forms.Button btnGetAll;
        private NavigatorControl navigatorControl1;
    }
}