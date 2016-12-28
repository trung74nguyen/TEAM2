namespace WindowsFormsApplication
{
    partial class GUI_BranchImportBallot
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHCN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNHTS = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLTTKM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.lstBallotDetail = new System.Windows.Forms.DataGridView();
            this.BallotCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstBallot = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBallotDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBallot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(588, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 49;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(107, 20);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            // 
            // btnQLNHCN
            // 
            this.btnQLNHCN.Name = "btnQLNHCN";
            this.btnQLNHCN.Size = new System.Drawing.Size(231, 22);
            this.btnQLNHCN.Text = "Quản lý nhập hàng chi nhánh";
            // 
            // btnQLNHTS
            // 
            this.btnQLNHTS.Name = "btnQLNHTS";
            this.btnQLNHTS.Size = new System.Drawing.Size(231, 22);
            this.btnQLNHTS.Text = "Quản lý nhập hàng trụ sở";
            // 
            // btnQLNH
            // 
            this.btnQLNH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLNHTS,
            this.btnQLNHCN});
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
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTKe
            // 
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(69, 20);
            this.btnTKe.Text = "Thống kê";
            // 
            // lstBallotDetail
            // 
            this.lstBallotDetail.AllowUserToAddRows = false;
            this.lstBallotDetail.AllowUserToDeleteRows = false;
            this.lstBallotDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBallotDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BallotCode,
            this.ProductCode,
            this.Number,
            this.State});
            this.lstBallotDetail.Location = new System.Drawing.Point(373, 142);
            this.lstBallotDetail.Margin = new System.Windows.Forms.Padding(2);
            this.lstBallotDetail.Name = "lstBallotDetail";
            this.lstBallotDetail.ReadOnly = true;
            this.lstBallotDetail.RowTemplate.Height = 24;
            this.lstBallotDetail.Size = new System.Drawing.Size(290, 225);
            this.lstBallotDetail.TabIndex = 47;
            // 
            // BallotCode
            // 
            this.BallotCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BallotCode.HeaderText = "Số phiếu";
            this.BallotCode.Name = "BallotCode";
            this.BallotCode.ReadOnly = true;
            this.BallotCode.Width = 74;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductCode.HeaderText = "Mã SP";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 64;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "SL";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 45;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.HeaderText = "Status";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 62;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(451, 115);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstBallot
            // 
            this.lstBallot.AllowUserToAddRows = false;
            this.lstBallot.AllowUserToDeleteRows = false;
            this.lstBallot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBallot.Location = new System.Drawing.Point(9, 142);
            this.lstBallot.Margin = new System.Windows.Forms.Padding(2);
            this.lstBallot.Name = "lstBallot";
            this.lstBallot.ReadOnly = true;
            this.lstBallot.RowTemplate.Height = 24;
            this.lstBallot.Size = new System.Drawing.Size(360, 225);
            this.lstBallot.TabIndex = 45;
            this.lstBallot.DoubleClick += new System.EventHandler(this.selectUpdateBranchImportBallot);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(169, 110);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 28);
            this.btnPrint.TabIndex = 44;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.clickPrint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(86, 110);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 28);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.clickUpdate);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(7, 110);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 28);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.clickInsert);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Quản lý nhập hàng chi nhánh";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(576, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 13);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Nguyễn Cao Lâm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Quản lý chi nhánh:";
            // 
            // GUI_BranchImportBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 378);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstBallotDetail);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstBallot);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_BranchImportBallot";
            this.Text = "GUI_BranchImportBallot";
            this.Load += new System.EventHandler(this.showBranchImportBallot);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBallotDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBallot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem btnQLHD;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHCN;
        private System.Windows.Forms.ToolStripMenuItem btnQLNHTS;
        private System.Windows.Forms.ToolStripMenuItem btnQLNH;
        private System.Windows.Forms.ToolStripMenuItem btnQLTTKM;
        private System.Windows.Forms.ToolStripMenuItem btnQLLSG;
        private System.Windows.Forms.ToolStripMenuItem btnQLSP;
        private System.Windows.Forms.ToolStripMenuItem btnQLDM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnTKe;
        private System.Windows.Forms.DataGridView lstBallotDetail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView lstBallot;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BallotCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;

    }
}