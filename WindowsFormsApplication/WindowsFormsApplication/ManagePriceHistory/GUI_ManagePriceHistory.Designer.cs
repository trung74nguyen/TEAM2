namespace WindowsFormsApplication.ManagePriceHistory
{
    partial class GUI_ManagePriceHistory
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
            this.btnDeletePriceHistory = new System.Windows.Forms.Button();
            this.btnUpdatePriceHistory = new System.Windows.Forms.Button();
            this.btnAddPriceHistory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstPriceHistory = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHTS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHCN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLTTKM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.lstPriceHistory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(860, 108);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // btnDeletePriceHistory
            // 
            this.btnDeletePriceHistory.Location = new System.Drawing.Point(221, 106);
            this.btnDeletePriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePriceHistory.Name = "btnDeletePriceHistory";
            this.btnDeletePriceHistory.Size = new System.Drawing.Size(95, 28);
            this.btnDeletePriceHistory.TabIndex = 18;
            this.btnDeletePriceHistory.Text = "Xóa";
            this.btnDeletePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePriceHistory
            // 
            this.btnUpdatePriceHistory.Enabled = false;
            this.btnUpdatePriceHistory.Location = new System.Drawing.Point(119, 106);
            this.btnUpdatePriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePriceHistory.Name = "btnUpdatePriceHistory";
            this.btnUpdatePriceHistory.Size = new System.Drawing.Size(95, 28);
            this.btnUpdatePriceHistory.TabIndex = 17;
            this.btnUpdatePriceHistory.Text = "Cập nhật";
            this.btnUpdatePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnAddPriceHistory
            // 
            this.btnAddPriceHistory.Location = new System.Drawing.Point(16, 106);
            this.btnAddPriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPriceHistory.Name = "btnAddPriceHistory";
            this.btnAddPriceHistory.Size = new System.Drawing.Size(95, 28);
            this.btnAddPriceHistory.TabIndex = 16;
            this.btnAddPriceHistory.Text = "Thêm";
            this.btnAddPriceHistory.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(403, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "QUẢN LÝ LỊCH SỬ GIÁ";
            // 
            // lstPriceHistory
            // 
            this.lstPriceHistory.AllowUserToAddRows = false;
            this.lstPriceHistory.AllowUserToDeleteRows = false;
            this.lstPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPriceHistory.Location = new System.Drawing.Point(16, 142);
            this.lstPriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lstPriceHistory.Name = "lstPriceHistory";
            this.lstPriceHistory.ReadOnly = true;
            this.lstPriceHistory.Size = new System.Drawing.Size(1061, 310);
            this.lstPriceHistory.TabIndex = 14;
            this.lstPriceHistory.DoubleClick += new System.EventHandler(this.selectPriceHistoryToUpdate);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1036, 37);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "ABCD";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(967, 37);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(72, 17);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Giám đốc:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1000, 1);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 28);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(195, 35);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // quảnLýNhậpHàngToolStripMenuItem
            // 
            this.quảnLýNhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLNHTS,
            this.btnQLNHCN});
            this.quảnLýNhậpHàngToolStripMenuItem.Name = "quảnLýNhậpHàngToolStripMenuItem";
            this.quảnLýNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(220, 35);
            this.quảnLýNhậpHàngToolStripMenuItem.Text = "Quản lý nhập hàng";
            // 
            // btnQLNHTS
            // 
            this.btnQLNHTS.Name = "btnQLNHTS";
            this.btnQLNHTS.Size = new System.Drawing.Size(394, 36);
            this.btnQLNHTS.Text = "Quản lý nhập hàng trụ sở";
            this.btnQLNHTS.Click += new System.EventHandler(this.btnQLNHTS_Click);
            // 
            // btnQLNHCN
            // 
            this.btnQLNHCN.Name = "btnQLNHCN";
            this.btnQLNHCN.Size = new System.Drawing.Size(394, 36);
            this.btnQLNHCN.Text = "Quản lý nhập hàng chi nhánh";
            this.btnQLNHCN.Click += new System.EventHandler(this.btnQLNHCN_Click);
            // 
            // btnQLTTKM
            // 
            this.btnQLTTKM.Name = "btnQLTTKM";
            this.btnQLTTKM.Size = new System.Drawing.Size(395, 36);
            this.btnQLTTKM.Text = "Quản lý thông tin khuyến mãi";
            this.btnQLTTKM.Click += new System.EventHandler(this.btnQLTTKM_Click);
            // 
            // btnQLLSG
            // 
            this.btnQLLSG.Name = "btnQLLSG";
            this.btnQLLSG.Size = new System.Drawing.Size(395, 36);
            this.btnQLLSG.Text = "Quản lý lịch sử giá";
            this.btnQLLSG.Click += new System.EventHandler(this.btnQLLSG_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(395, 36);
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLSP,
            this.btnQLLSG,
            this.btnQLTTKM});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(212, 35);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // btnTK
            // 
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(120, 35);
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýNhậpHàngToolStripMenuItem,
            this.btnQLHD,
            this.btnTK});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1095, 39);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GUI_ManagePriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 468);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDeletePriceHistory);
            this.Controls.Add(this.btnUpdatePriceHistory);
            this.Controls.Add(this.btnAddPriceHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstPriceHistory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_ManagePriceHistory";
            this.Text = " PHẦM MỀM QUẢN LÝ CỬA HÀNG TIỆN LỢI";
            this.Load += new System.EventHandler(this.showManagePriceHistoryForm);
            ((System.ComponentModel.ISupportInitialize)(this.lstPriceHistory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDeletePriceHistory;
        private System.Windows.Forms.Button btnUpdatePriceHistory;
        private System.Windows.Forms.Button btnAddPriceHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView lstPriceHistory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnQLHD;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQLTTKM;
        private System.Windows.Forms.ToolStripMenuItem btnQLLSG;
        private System.Windows.Forms.ToolStripMenuItem btnQLSP;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHTS;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHCN;
    }
}