namespace WindowsFormsApplication.ManageProduct
{
    partial class GUI_ManageProduct
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLTTKM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.lstManageProduct = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLDM,
            this.btnQLNH,
            this.btnQLHD,
            this.btnTKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnQLDM
            // 
            this.btnQLDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLSP,
            this.btnQLLSG,
            this.btnQLTTKM});
            this.btnQLDM.Name = "btnQLDM";
            this.btnQLDM.Size = new System.Drawing.Size(117, 20);
            this.btnQLDM.Text = "Quản lý danh mục";
            // 
            // btnQLSP
            // 
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(232, 22);
            this.btnQLSP.Text = "Quản lý sản phẩm";
            // 
            // btnQLLSG
            // 
            this.btnQLLSG.Name = "btnQLLSG";
            this.btnQLLSG.Size = new System.Drawing.Size(232, 22);
            this.btnQLLSG.Text = "Quản lý lịch sử giá";
            // 
            // btnQLTTKM
            // 
            this.btnQLTTKM.Name = "btnQLTTKM";
            this.btnQLTTKM.Size = new System.Drawing.Size(232, 22);
            this.btnQLTTKM.Text = "Quản lý thông tin khuyến mãi";
            // 
            // btnQLNH
            // 
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(120, 20);
            this.btnQLNH.Text = "Quản lý nhập hàng";
            // 
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(107, 20);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            // 
            // btnTKe
            // 
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(69, 20);
            this.btnTKe.Text = "Thống kê";
            // 
            // lstManageProduct
            // 
            this.lstManageProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageProduct.Location = new System.Drawing.Point(12, 136);
            this.lstManageProduct.Name = "lstManageProduct";
            this.lstManageProduct.Size = new System.Drawing.Size(653, 238);
            this.lstManageProduct.TabIndex = 27;
            this.lstManageProduct.DoubleClick += new System.EventHandler(this.selectProductToUpdate);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(484, 102);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 24);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.Text = "Tìm kiếm...";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(197, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.clickUpdate);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 37);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.clickInsert);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 31);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Quản lý sản phẩm";
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(441, 26);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(224, 23);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "Giám đốc: ABC";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(590, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // GUI_ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 386);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstManageProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPosition);
            this.Name = "GUI_ManageProduct";
            this.Text = "GUI_ManageProduct";
            this.Load += new System.EventHandler(this.showManageProductForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnQLDM;
        private System.Windows.Forms.ToolStripMenuItem btnQLSP;
        private System.Windows.Forms.ToolStripMenuItem btnQLLSG;
        private System.Windows.Forms.ToolStripMenuItem btnQLTTKM;
        private System.Windows.Forms.ToolStripMenuItem btnQLNH;
        private System.Windows.Forms.ToolStripMenuItem btnQLHD;
        private System.Windows.Forms.ToolStripMenuItem btnTKe;
        private System.Windows.Forms.DataGridView lstManageProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnLogOut;
    }
}