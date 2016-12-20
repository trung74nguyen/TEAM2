﻿namespace WindowsFormsApplication.HeadquarterImportBallot
{
    partial class GUI_HeadquarterImportBallot
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstHeadquarterImportBallot = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstHeadquarterImportBallotDetail = new System.Windows.Forms.DataGridView();
            this.BallotCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntoMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallotDetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nhân viên kiểm kho:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(589, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Lâm Tấn Toàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quản lý nhập hàng trụ sở";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(9, 111);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 28);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.clickInsert);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 111);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 28);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.clickUpdate);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(171, 111);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 28);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.clickPrint);
            // 
            // lstHeadquarterImportBallot
            // 
            this.lstHeadquarterImportBallot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstHeadquarterImportBallot.Location = new System.Drawing.Point(11, 143);
            this.lstHeadquarterImportBallot.Margin = new System.Windows.Forms.Padding(2);
            this.lstHeadquarterImportBallot.Name = "lstHeadquarterImportBallot";
            this.lstHeadquarterImportBallot.RowTemplate.Height = 24;
            this.lstHeadquarterImportBallot.Size = new System.Drawing.Size(224, 225);
            this.lstHeadquarterImportBallot.TabIndex = 34;
            this.lstHeadquarterImportBallot.DoubleClick += new System.EventHandler(this.selectUpdateHeadquarterImportBallot);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(453, 116);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.clickSearch);
            // 
            // lstHeadquarterImportBallotDetail
            // 
            this.lstHeadquarterImportBallotDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstHeadquarterImportBallotDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BallotCode,
            this.ProductCode,
            this.Number,
            this.InputPrice,
            this.EXP,
            this.State,
            this.IntoMoney});
            this.lstHeadquarterImportBallotDetail.Location = new System.Drawing.Point(253, 143);
            this.lstHeadquarterImportBallotDetail.Margin = new System.Windows.Forms.Padding(2);
            this.lstHeadquarterImportBallotDetail.Name = "lstHeadquarterImportBallotDetail";
            this.lstHeadquarterImportBallotDetail.RowTemplate.Height = 24;
            this.lstHeadquarterImportBallotDetail.Size = new System.Drawing.Size(412, 225);
            this.lstHeadquarterImportBallotDetail.TabIndex = 36;
            // 
            // BallotCode
            // 
            this.BallotCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BallotCode.HeaderText = "Số phiếu";
            this.BallotCode.Name = "BallotCode";
            this.BallotCode.Width = 74;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductCode.HeaderText = "Mã SP";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 64;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "SL";
            this.Number.Name = "Number";
            this.Number.Width = 45;
            // 
            // InputPrice
            // 
            this.InputPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InputPrice.HeaderText = "Giá";
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Width = 48;
            // 
            // EXP
            // 
            this.EXP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EXP.HeaderText = "Hạn sử dụng";
            this.EXP.Name = "EXP";
            this.EXP.Width = 93;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.HeaderText = "Status";
            this.State.Name = "State";
            this.State.Width = 62;
            // 
            // IntoMoney
            // 
            this.IntoMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IntoMoney.HeaderText = "Thành tiền";
            this.IntoMoney.Name = "IntoMoney";
            this.IntoMoney.Width = 83;
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
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 37;
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
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLLSG
            // 
            this.btnQLLSG.Name = "btnQLLSG";
            this.btnQLLSG.Size = new System.Drawing.Size(232, 22);
            this.btnQLLSG.Text = "Quản lý lịch sử giá";
            this.btnQLLSG.Click += new System.EventHandler(this.btnQLLSG_Click);
            // 
            // btnQLTTKM
            // 
            this.btnQLTTKM.Name = "btnQLTTKM";
            this.btnQLTTKM.Size = new System.Drawing.Size(232, 22);
            this.btnQLTTKM.Text = "Quản lý thông tin khuyến mãi";
            this.btnQLTTKM.Click += new System.EventHandler(this.btnQLTTKM_Click);
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
            // btnQLNHTS
            // 
            this.btnQLNHTS.Name = "btnQLNHTS";
            this.btnQLNHTS.Size = new System.Drawing.Size(231, 22);
            this.btnQLNHTS.Text = "Quản lý nhập hàng trụ sở";
            this.btnQLNHTS.Click += new System.EventHandler(this.btnQLNHTS_Click);
            // 
            // btnQLNHCN
            // 
            this.btnQLNHCN.Name = "btnQLNHCN";
            this.btnQLNHCN.Size = new System.Drawing.Size(231, 22);
            this.btnQLNHCN.Text = "Quản lý nhập hàng chi nhánh";
            this.btnQLNHCN.Click += new System.EventHandler(this.btnQLNHCN_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(107, 20);
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnTKe
            // 
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(69, 20);
            this.btnTKe.Text = "Thống kê";
            this.btnTKe.Click += new System.EventHandler(this.btnTKe_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(590, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // GUI_HeadquarterImportBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 379);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstHeadquarterImportBallotDetail);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstHeadquarterImportBallot);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_HeadquarterImportBallot";
            this.Text = "GUI_HeadquarterImportBallot";
            this.Load += new System.EventHandler(this.showHeadquarterImportBallot);
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallotDetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView lstHeadquarterImportBallot;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView lstHeadquarterImportBallotDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn BallotCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntoMoney;
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