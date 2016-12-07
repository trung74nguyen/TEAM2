namespace WindowsFormsApplication.ManageBill
{
    partial class GUI_ManageBill
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
            this.lstPromotion = new System.Windows.Forms.DataGridView();
            this.lstManagePromotion = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLTTKM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.lstPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstManagePromotion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPromotion
            // 
            this.lstPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPromotion.Location = new System.Drawing.Point(12, 159);
            this.lstPromotion.Name = "lstPromotion";
            this.lstPromotion.Size = new System.Drawing.Size(218, 238);
            this.lstPromotion.TabIndex = 25;
            // 
            // lstManagePromotion
            // 
            this.lstManagePromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManagePromotion.Location = new System.Drawing.Point(236, 159);
            this.lstManagePromotion.Name = "lstManagePromotion";
            this.lstManagePromotion.Size = new System.Drawing.Size(429, 238);
            this.lstManagePromotion.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(484, 125);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 24);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Text = "Tìm kiếm...";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(197, 116);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 37);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 37);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 116);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 37);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(441, 33);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(224, 23);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "abc";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(588, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(77, 24);
            this.btnSignOut.TabIndex = 18;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(230, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 31);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Quản lý hóa đơn";
            // 
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(107, 20);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            // 
            // btnQLNH
            // 
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(120, 20);
            this.btnQLNH.Text = "Quản lý nhập hàng";
            // 
            // btnQLTTKM
            // 
            this.btnQLTTKM.Name = "btnQLTTKM";
            this.btnQLTTKM.Size = new System.Drawing.Size(232, 22);
            this.btnQLTTKM.Text = "Quản lý thông tin khuyến mãi";
            // 
            // btnQLLSG
            // 
            this.btnQLLSG.Name = "btnQLLSG";
            this.btnQLLSG.Size = new System.Drawing.Size(232, 22);
            this.btnQLLSG.Text = "Quản lý lịch sử giá";
            // 
            // btnQLSP
            // 
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(232, 22);
            this.btnQLSP.Text = "Quản lý sản phẩm";
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
            // btnTKe
            // 
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(69, 20);
            this.btnTKe.Text = "Thống kê";
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
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GUI_ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 403);
            this.Controls.Add(this.lstPromotion);
            this.Controls.Add(this.lstManagePromotion);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GUI_ManageBill";
            this.Text = "GUI_ManageBill";
            ((System.ComponentModel.ISupportInitialize)(this.lstPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstManagePromotion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstPromotion;
        private System.Windows.Forms.DataGridView lstManagePromotion;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem btnQLHD;
        private System.Windows.Forms.ToolStripMenuItem btnQLNH;
        private System.Windows.Forms.ToolStripMenuItem btnQLTTKM;
        private System.Windows.Forms.ToolStripMenuItem btnQLLSG;
        private System.Windows.Forms.ToolStripMenuItem btnQLSP;
        private System.Windows.Forms.ToolStripMenuItem btnQLDM;
        private System.Windows.Forms.ToolStripMenuItem btnTKe;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}