namespace WindowsFormsApplication.Home
{
    partial class GUI_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Home));
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.linkStatistic = new System.Windows.Forms.LinkLabel();
            this.linkManageBill = new System.Windows.Forms.LinkLabel();
            this.linkBranchImportBallot = new System.Windows.Forms.LinkLabel();
            this.linkHeadquarterImportBallot = new System.Windows.Forms.LinkLabel();
            this.linkManagePromotion = new System.Windows.Forms.LinkLabel();
            this.linkManagePriceHistory = new System.Windows.Forms.LinkLabel();
            this.linkManageProduct = new System.Windows.Forms.LinkLabel();
            this.picManageProduct = new System.Windows.Forms.PictureBox();
            this.picManagePriceHistory = new System.Windows.Forms.PictureBox();
            this.picManagePromotion = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picBranchImportBallot = new System.Windows.Forms.PictureBox();
            this.picHeadquarterImportBallot = new System.Windows.Forms.PictureBox();
            this.picManageBill = new System.Windows.Forms.PictureBox();
            this.picStatistic = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picManageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagePriceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagePromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBranchImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadquarterImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkExit.Location = new System.Drawing.Point(614, 383);
            this.linkExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(43, 16);
            this.linkExit.TabIndex = 32;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Thoát";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Close_LinkClicked);
            // 
            // linkStatistic
            // 
            this.linkStatistic.AutoSize = true;
            this.linkStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStatistic.Location = new System.Drawing.Point(384, 383);
            this.linkStatistic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkStatistic.Name = "linkStatistic";
            this.linkStatistic.Size = new System.Drawing.Size(136, 16);
            this.linkStatistic.TabIndex = 31;
            this.linkStatistic.TabStop = true;
            this.linkStatistic.Text = "Thống kê và báo cáo";
            this.linkStatistic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageSalesStatistics_LinkClicked);
            // 
            // linkManageBill
            // 
            this.linkManageBill.AutoSize = true;
            this.linkManageBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManageBill.Location = new System.Drawing.Point(584, 194);
            this.linkManageBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkManageBill.Name = "linkManageBill";
            this.linkManageBill.Size = new System.Drawing.Size(105, 16);
            this.linkManageBill.TabIndex = 30;
            this.linkManageBill.TabStop = true;
            this.linkManageBill.Text = "Quản lý hóa đơn";
            this.linkManageBill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageBill_LinkClicked);
            // 
            // linkBranchImportBallot
            // 
            this.linkBranchImportBallot.AutoSize = true;
            this.linkBranchImportBallot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBranchImportBallot.Location = new System.Drawing.Point(186, 383);
            this.linkBranchImportBallot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkBranchImportBallot.Name = "linkBranchImportBallot";
            this.linkBranchImportBallot.Size = new System.Drawing.Size(178, 16);
            this.linkBranchImportBallot.TabIndex = 29;
            this.linkBranchImportBallot.TabStop = true;
            this.linkBranchImportBallot.Text = "Quản lý nhập hàng chi nhánh";
            this.linkBranchImportBallot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BranchImportBallot_LinkClicked);
            // 
            // linkHeadquarterImportBallot
            // 
            this.linkHeadquarterImportBallot.AutoSize = true;
            this.linkHeadquarterImportBallot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHeadquarterImportBallot.Location = new System.Drawing.Point(14, 383);
            this.linkHeadquarterImportBallot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkHeadquarterImportBallot.Name = "linkHeadquarterImportBallot";
            this.linkHeadquarterImportBallot.Size = new System.Drawing.Size(154, 16);
            this.linkHeadquarterImportBallot.TabIndex = 28;
            this.linkHeadquarterImportBallot.TabStop = true;
            this.linkHeadquarterImportBallot.Text = "Quản lý nhập hàng trụ sở";
            this.linkHeadquarterImportBallot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HeadquarterImportBallot_LinkClicked);
            // 
            // linkManagePromotion
            // 
            this.linkManagePromotion.AutoSize = true;
            this.linkManagePromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManagePromotion.Location = new System.Drawing.Point(369, 194);
            this.linkManagePromotion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkManagePromotion.Name = "linkManagePromotion";
            this.linkManagePromotion.Size = new System.Drawing.Size(176, 16);
            this.linkManagePromotion.TabIndex = 27;
            this.linkManagePromotion.TabStop = true;
            this.linkManagePromotion.Text = "Quản lý thông tin khuyến mãi";
            this.linkManagePromotion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManagePromotion_LinkClicked);
            // 
            // linkManagePriceHistory
            // 
            this.linkManagePriceHistory.AutoSize = true;
            this.linkManagePriceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManagePriceHistory.Location = new System.Drawing.Point(217, 194);
            this.linkManagePriceHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkManagePriceHistory.Name = "linkManagePriceHistory";
            this.linkManagePriceHistory.Size = new System.Drawing.Size(115, 16);
            this.linkManagePriceHistory.TabIndex = 26;
            this.linkManagePriceHistory.TabStop = true;
            this.linkManagePriceHistory.Text = "Quản lý lịch sử giá";
            this.linkManagePriceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManagePriceHistory_LinkClicked);
            // 
            // linkManageProduct
            // 
            this.linkManageProduct.AutoSize = true;
            this.linkManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManageProduct.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(239)))));
            this.linkManageProduct.Location = new System.Drawing.Point(35, 194);
            this.linkManageProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkManageProduct.Name = "linkManageProduct";
            this.linkManageProduct.Size = new System.Drawing.Size(115, 16);
            this.linkManageProduct.TabIndex = 25;
            this.linkManageProduct.TabStop = true;
            this.linkManageProduct.Text = "Quản lý sản phẩm";
            this.linkManageProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageProduct_LinkClicked);
            // 
            // picManageProduct
            // 
            this.picManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("picManageProduct.Image")));
            this.picManageProduct.Location = new System.Drawing.Point(38, 52);
            this.picManageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.picManageProduct.Name = "picManageProduct";
            this.picManageProduct.Size = new System.Drawing.Size(110, 140);
            this.picManageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManageProduct.TabIndex = 24;
            this.picManageProduct.TabStop = false;
            this.picManageProduct.Click += new System.EventHandler(this.ManageProduct_Click);
            // 
            // picManagePriceHistory
            // 
            this.picManagePriceHistory.Image = ((System.Drawing.Image)(resources.GetObject("picManagePriceHistory.Image")));
            this.picManagePriceHistory.Location = new System.Drawing.Point(220, 52);
            this.picManagePriceHistory.Margin = new System.Windows.Forms.Padding(2);
            this.picManagePriceHistory.Name = "picManagePriceHistory";
            this.picManagePriceHistory.Size = new System.Drawing.Size(110, 140);
            this.picManagePriceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManagePriceHistory.TabIndex = 23;
            this.picManagePriceHistory.TabStop = false;
            this.picManagePriceHistory.Click += new System.EventHandler(this.ManagePriceHistory_Click);
            // 
            // picManagePromotion
            // 
            this.picManagePromotion.Image = ((System.Drawing.Image)(resources.GetObject("picManagePromotion.Image")));
            this.picManagePromotion.Location = new System.Drawing.Point(400, 52);
            this.picManagePromotion.Margin = new System.Windows.Forms.Padding(2);
            this.picManagePromotion.Name = "picManagePromotion";
            this.picManagePromotion.Size = new System.Drawing.Size(110, 140);
            this.picManagePromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManagePromotion.TabIndex = 22;
            this.picManagePromotion.TabStop = false;
            this.picManagePromotion.Click += new System.EventHandler(this.ManagegPromotion_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(579, 241);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(110, 140);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picExit.TabIndex = 21;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.Close_Click);
            // 
            // picBranchImportBallot
            // 
            this.picBranchImportBallot.Image = ((System.Drawing.Image)(resources.GetObject("picBranchImportBallot.Image")));
            this.picBranchImportBallot.Location = new System.Drawing.Point(220, 241);
            this.picBranchImportBallot.Margin = new System.Windows.Forms.Padding(2);
            this.picBranchImportBallot.Name = "picBranchImportBallot";
            this.picBranchImportBallot.Size = new System.Drawing.Size(110, 140);
            this.picBranchImportBallot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBranchImportBallot.TabIndex = 20;
            this.picBranchImportBallot.TabStop = false;
            this.picBranchImportBallot.Click += new System.EventHandler(this.BranchImportBallot_Click);
            // 
            // picHeadquarterImportBallot
            // 
            this.picHeadquarterImportBallot.Image = ((System.Drawing.Image)(resources.GetObject("picHeadquarterImportBallot.Image")));
            this.picHeadquarterImportBallot.Location = new System.Drawing.Point(38, 241);
            this.picHeadquarterImportBallot.Margin = new System.Windows.Forms.Padding(2);
            this.picHeadquarterImportBallot.Name = "picHeadquarterImportBallot";
            this.picHeadquarterImportBallot.Size = new System.Drawing.Size(110, 140);
            this.picHeadquarterImportBallot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadquarterImportBallot.TabIndex = 19;
            this.picHeadquarterImportBallot.TabStop = false;
            this.picHeadquarterImportBallot.Click += new System.EventHandler(this.HeadquarterImportBallot_Click);
            // 
            // picManageBill
            // 
            this.picManageBill.Image = ((System.Drawing.Image)(resources.GetObject("picManageBill.Image")));
            this.picManageBill.Location = new System.Drawing.Point(579, 52);
            this.picManageBill.Margin = new System.Windows.Forms.Padding(2);
            this.picManageBill.Name = "picManageBill";
            this.picManageBill.Size = new System.Drawing.Size(110, 140);
            this.picManageBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManageBill.TabIndex = 18;
            this.picManageBill.TabStop = false;
            this.picManageBill.Click += new System.EventHandler(this.ManageBill_Click);
            // 
            // picStatistic
            // 
            this.picStatistic.Image = ((System.Drawing.Image)(resources.GetObject("picStatistic.Image")));
            this.picStatistic.Location = new System.Drawing.Point(400, 241);
            this.picStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.picStatistic.Name = "picStatistic";
            this.picStatistic.Size = new System.Drawing.Size(110, 140);
            this.picStatistic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatistic.TabIndex = 17;
            this.picStatistic.TabStop = false;
            this.picStatistic.Click += new System.EventHandler(this.ManageSalesStatustic_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(713, 31);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "PHẦN MỀM QUẢN LÝ DOANH THU CÔNG TY CMART";
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.linkStatistic);
            this.Controls.Add(this.linkManageBill);
            this.Controls.Add(this.linkBranchImportBallot);
            this.Controls.Add(this.linkHeadquarterImportBallot);
            this.Controls.Add(this.linkManagePromotion);
            this.Controls.Add(this.linkManagePriceHistory);
            this.Controls.Add(this.linkManageProduct);
            this.Controls.Add(this.picManageProduct);
            this.Controls.Add(this.picManagePriceHistory);
            this.Controls.Add(this.picManagePromotion);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picBranchImportBallot);
            this.Controls.Add(this.picHeadquarterImportBallot);
            this.Controls.Add(this.picManageBill);
            this.Controls.Add(this.picStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GUI_Home";
            this.Text = "PHẦN MỀM QUẢN LÝ DOANH THU CÔNG TY CMART";
            ((System.ComponentModel.ISupportInitialize)(this.picManageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagePriceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagePromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBranchImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadquarterImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.LinkLabel linkStatistic;
        private System.Windows.Forms.LinkLabel linkManageBill;
        private System.Windows.Forms.LinkLabel linkBranchImportBallot;
        private System.Windows.Forms.LinkLabel linkHeadquarterImportBallot;
        private System.Windows.Forms.LinkLabel linkManagePromotion;
        private System.Windows.Forms.LinkLabel linkManagePriceHistory;
        private System.Windows.Forms.LinkLabel linkManageProduct;
        private System.Windows.Forms.PictureBox picManageProduct;
        private System.Windows.Forms.PictureBox picManagePriceHistory;
        private System.Windows.Forms.PictureBox picManagePromotion;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picBranchImportBallot;
        private System.Windows.Forms.PictureBox picHeadquarterImportBallot;
        private System.Windows.Forms.PictureBox picManageBill;
        private System.Windows.Forms.PictureBox picStatistic;
        private System.Windows.Forms.Label lblTitle;
    }
}