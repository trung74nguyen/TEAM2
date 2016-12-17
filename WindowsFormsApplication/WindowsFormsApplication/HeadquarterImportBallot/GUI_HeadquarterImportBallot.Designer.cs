namespace WindowsFormsApplication.HeadquarterImportBallot
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLýNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpHàngTrụSởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpHàngChiNhánhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallotDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quanLýNhậpHàngToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản Lý Danh Mục";
            // 
            // quanLýNhậpHàngToolStripMenuItem
            // 
            this.quanLýNhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhậpHàngTrụSởToolStripMenuItem,
            this.quảnLýNhậpHàngChiNhánhToolStripMenuItem});
            this.quanLýNhậpHàngToolStripMenuItem.Name = "quanLýNhậpHàngToolStripMenuItem";
            this.quanLýNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.quanLýNhậpHàngToolStripMenuItem.Text = "Quản Lý Nhập Hàng";
            // 
            // quảnLýNhậpHàngTrụSởToolStripMenuItem
            // 
            this.quảnLýNhậpHàngTrụSởToolStripMenuItem.Name = "quảnLýNhậpHàngTrụSởToolStripMenuItem";
            this.quảnLýNhậpHàngTrụSởToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.quảnLýNhậpHàngTrụSởToolStripMenuItem.Text = "Quản Lý Nhập Hàng Trụ Sở";
            // 
            // quảnLýNhậpHàngChiNhánhToolStripMenuItem
            // 
            this.quảnLýNhậpHàngChiNhánhToolStripMenuItem.Name = "quảnLýNhậpHàngChiNhánhToolStripMenuItem";
            this.quảnLýNhậpHàngChiNhánhToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.quảnLýNhậpHàngChiNhánhToolStripMenuItem.Text = "Quản Lý Nhập Hàng Chi Nhánh";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Quản lý chi nhánh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nguyễn Văn A";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(602, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 24);
            this.button1.TabIndex = 29;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
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
            // GUI_HeadquarterImportBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 379);
            this.Controls.Add(this.lstHeadquarterImportBallotDetail);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstHeadquarterImportBallot);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_HeadquarterImportBallot";
            this.Text = "GUI_HeadquarterImportBallot";
            this.Load += new System.EventHandler(this.showHeadquarterImportBallot);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstHeadquarterImportBallotDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLýNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngTrụSởToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngChiNhánhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
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

    }
}