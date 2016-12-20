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
            this.lstManageBill = new System.Windows.Forms.DataGridView();
            this.lstManageBillDetail = new System.Windows.Forms.DataGridView();
            this.BallotNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLTTKM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHTS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHCN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillDetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstManageBill
            // 
            this.lstManageBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBill.Location = new System.Drawing.Point(16, 196);
            this.lstManageBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstManageBill.Name = "lstManageBill";
            this.lstManageBill.Size = new System.Drawing.Size(291, 293);
            this.lstManageBill.TabIndex = 25;
            this.lstManageBill.DoubleClick += new System.EventHandler(this.selectBillToUpdate);
            // 
            // lstManageBillDetail
            // 
            this.lstManageBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BallotNum,
            this.ProductCode,
            this.ProductName_,
            this.UnitPrice,
            this.Number,
            this.Total});
            this.lstManageBillDetail.Location = new System.Drawing.Point(315, 196);
            this.lstManageBillDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstManageBillDetail.Name = "lstManageBillDetail";
            this.lstManageBillDetail.Size = new System.Drawing.Size(572, 293);
            this.lstManageBillDetail.TabIndex = 24;
            // 
            // BallotNum
            // 
            this.BallotNum.DataPropertyName = "BallotNum";
            this.BallotNum.HeaderText = "Mã hóa đơn";
            this.BallotNum.Name = "BallotNum";
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Mã sản phẩm";
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName_
            // 
            this.ProductName_.DataPropertyName = "ProductName";
            this.ProductName_.HeaderText = "Tên sản phẩm";
            this.ProductName_.Name = "ProductName_";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng";
            this.Number.Name = "Number";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(645, 154);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 29);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.clickSearch);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(263, 143);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 46);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 143);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 46);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(16, 143);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 46);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(588, 41);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(299, 28);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "TK000005";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(307, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 38);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Quản lý hóa đơn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLDM,
            this.btnQLNH,
            this.btnQLHD,
            this.btnTKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(903, 39);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnQLDM
            // 
            this.btnQLDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLSP,
            this.btnQLLSG,
            this.btnQLTTKM});
            this.btnQLDM.Name = "btnQLDM";
            this.btnQLDM.Size = new System.Drawing.Size(212, 35);
            this.btnQLDM.Text = "Quản lý danh mục";
            // 
            // btnQLSP
            // 
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(395, 36);
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLLSG
            // 
            this.btnQLLSG.Name = "btnQLLSG";
            this.btnQLLSG.Size = new System.Drawing.Size(395, 36);
            this.btnQLLSG.Text = "Quản lý lịch sử giá";
            this.btnQLLSG.Click += new System.EventHandler(this.btnQLLSG_Click);
            // 
            // btnQLTTKM
            // 
            this.btnQLTTKM.Name = "btnQLTTKM";
            this.btnQLTTKM.Size = new System.Drawing.Size(395, 36);
            this.btnQLTTKM.Text = "Quản lý thông tin khuyến mãi";
            this.btnQLTTKM.Click += new System.EventHandler(this.btnQLTTKM_Click);
            // 
            // btnQLNH
            // 
            this.btnQLNH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLNHTS,
            this.btnQLNHCN});
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(220, 35);
            this.btnQLNH.Text = "Quản lý nhập hàng";
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
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(195, 35);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnTKe
            // 
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(120, 35);
            this.btnTKe.Text = "Thống kê";
            this.btnTKe.Click += new System.EventHandler(this.btnTKe_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(791, 5);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 28);
            this.btnLogOut.TabIndex = 30;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // GUI_ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 496);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstManageBill);
            this.Controls.Add(this.lstManageBillDetail);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_ManageBill";
            this.Text = "GUI_ManageBill";
            this.Load += new System.EventHandler(this.showManageBillForm);
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillDetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstManageBill;
        private System.Windows.Forms.DataGridView lstManageBillDetail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BallotNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnQLDM;
        private System.Windows.Forms.ToolStripMenuItem btnQLSP;
        private System.Windows.Forms.ToolStripMenuItem btnQLLSG;
        private System.Windows.Forms.ToolStripMenuItem btnQLTTKM;
        private System.Windows.Forms.ToolStripMenuItem btnQLNH;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHTS;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHCN;
        private System.Windows.Forms.ToolStripMenuItem btnQLHD;
        private System.Windows.Forms.ToolStripMenuItem btnTKe;
        private System.Windows.Forms.Button btnLogOut;
    }
}