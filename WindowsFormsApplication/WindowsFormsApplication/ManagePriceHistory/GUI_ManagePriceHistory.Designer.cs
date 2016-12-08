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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeletePriceHistory = new System.Windows.Forms.Button();
            this.btnUpdatePriceHistory = new System.Windows.Forms.Button();
            this.btnAddPriceHistory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstPriceHistory = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLịchSửGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.lstPriceHistory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(645, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Tìm kiếm...";
            // 
            // btnDeletePriceHistory
            // 
            this.btnDeletePriceHistory.Location = new System.Drawing.Point(166, 86);
            this.btnDeletePriceHistory.Name = "btnDeletePriceHistory";
            this.btnDeletePriceHistory.Size = new System.Drawing.Size(71, 23);
            this.btnDeletePriceHistory.TabIndex = 18;
            this.btnDeletePriceHistory.Text = "Xóa";
            this.btnDeletePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePriceHistory
            // 
            this.btnUpdatePriceHistory.Location = new System.Drawing.Point(89, 86);
            this.btnUpdatePriceHistory.Name = "btnUpdatePriceHistory";
            this.btnUpdatePriceHistory.Size = new System.Drawing.Size(71, 23);
            this.btnUpdatePriceHistory.TabIndex = 17;
            this.btnUpdatePriceHistory.Text = "Cập nhật";
            this.btnUpdatePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnAddPriceHistory
            // 
            this.btnAddPriceHistory.Location = new System.Drawing.Point(12, 86);
            this.btnAddPriceHistory.Name = "btnAddPriceHistory";
            this.btnAddPriceHistory.Size = new System.Drawing.Size(71, 23);
            this.btnAddPriceHistory.TabIndex = 16;
            this.btnAddPriceHistory.Text = "Thêm";
            this.btnAddPriceHistory.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(302, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 24);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "QUẢN LÝ LỊCH SỬ GIÁ";
            // 
            // lstPriceHistory
            // 
            this.lstPriceHistory.AllowUserToAddRows = false;
            this.lstPriceHistory.AllowUserToDeleteRows = false;
            this.lstPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPriceHistory.Location = new System.Drawing.Point(12, 115);
            this.lstPriceHistory.Name = "lstPriceHistory";
            this.lstPriceHistory.ReadOnly = true;
            this.lstPriceHistory.Size = new System.Drawing.Size(796, 252);
            this.lstPriceHistory.TabIndex = 14;
            this.lstPriceHistory.DoubleClick += new System.EventHandler(this.lstPriceHistory_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(777, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "ABCD";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(725, 30);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 13);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Giám đốc:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(750, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(71, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // quảnLýNhậpHàngToolStripMenuItem
            // 
            this.quảnLýNhậpHàngToolStripMenuItem.Name = "quảnLýNhậpHàngToolStripMenuItem";
            this.quảnLýNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.quảnLýNhậpHàngToolStripMenuItem.Text = "Quản lý nhập hàng";
            // 
            // quảnLýThôngTinKhuyếnMãiToolStripMenuItem
            // 
            this.quảnLýThôngTinKhuyếnMãiToolStripMenuItem.Name = "quảnLýThôngTinKhuyếnMãiToolStripMenuItem";
            this.quảnLýThôngTinKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.quảnLýThôngTinKhuyếnMãiToolStripMenuItem.Text = "Quản lý thông tin khuyến mãi";
            // 
            // quảnLýLịchSửGiáToolStripMenuItem
            // 
            this.quảnLýLịchSửGiáToolStripMenuItem.Name = "quảnLýLịchSửGiáToolStripMenuItem";
            this.quảnLýLịchSửGiáToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.quảnLýLịchSửGiáToolStripMenuItem.Text = "Quản lý lịch sử giá";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýLịchSửGiáToolStripMenuItem,
            this.quảnLýThôngTinKhuyếnMãiToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýNhậpHàngToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GUI_ManagePriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 380);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeletePriceHistory);
            this.Controls.Add(this.btnUpdatePriceHistory);
            this.Controls.Add(this.btnAddPriceHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstPriceHistory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeletePriceHistory;
        private System.Windows.Forms.Button btnUpdatePriceHistory;
        private System.Windows.Forms.Button btnAddPriceHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView lstPriceHistory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchSửGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}