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
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ManageProduct = new System.Windows.Forms.PictureBox();
            this.ManagePriceHistory = new System.Windows.Forms.PictureBox();
            this.ManagegPromotion = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.BranchImportBallot = new System.Windows.Forms.PictureBox();
            this.HeadquarterImportBallot = new System.Windows.Forms.PictureBox();
            this.ManageBill = new System.Windows.Forms.PictureBox();
            this.ManageSalesStatustic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePriceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagegPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadquarterImportBallot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageSalesStatustic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(719, 439);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(45, 17);
            this.linkLabel8.TabIndex = 32;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Thoát";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Close_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(456, 439);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(142, 17);
            this.linkLabel7.TabIndex = 31;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Thống kê và báo cáo";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageSalesStatistics_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(253, 439);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(113, 17);
            this.linkLabel6.TabIndex = 30;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Quản lý hóa đơn";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageBill_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(12, 439);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(195, 17);
            this.linkLabel5.TabIndex = 29;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Quản lý nhập hàng chi nhánh";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BranchImportBallot_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(659, 209);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(169, 17);
            this.linkLabel4.TabIndex = 28;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Quản lý nhập hàng trụ sở";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HeadquarterImportBallot_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(427, 209);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(192, 17);
            this.linkLabel3.TabIndex = 27;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Quản lý thông tin khuyến mãi";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManagePromotion_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(250, 209);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(124, 17);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Quản lý lịch sử giá";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManagePriceHistory_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(43, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 17);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quản lý sản phẩm";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageProduct_LinkClicked);
            // 
            // ManageProduct
            // 
            this.ManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("ManageProduct.Image")));
            this.ManageProduct.Location = new System.Drawing.Point(29, 22);
            this.ManageProduct.Name = "ManageProduct";
            this.ManageProduct.Size = new System.Drawing.Size(152, 173);
            this.ManageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageProduct.TabIndex = 24;
            this.ManageProduct.TabStop = false;
            this.ManageProduct.Click += new System.EventHandler(this.ManageProduct_Click);
            // 
            // ManagePriceHistory
            // 
            this.ManagePriceHistory.Image = ((System.Drawing.Image)(resources.GetObject("ManagePriceHistory.Image")));
            this.ManagePriceHistory.Location = new System.Drawing.Point(235, 22);
            this.ManagePriceHistory.Name = "ManagePriceHistory";
            this.ManagePriceHistory.Size = new System.Drawing.Size(152, 173);
            this.ManagePriceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManagePriceHistory.TabIndex = 23;
            this.ManagePriceHistory.TabStop = false;
            this.ManagePriceHistory.Click += new System.EventHandler(this.ManagePriceHistory_Click);
            // 
            // ManagegPromotion
            // 
            this.ManagegPromotion.Image = ((System.Drawing.Image)(resources.GetObject("ManagegPromotion.Image")));
            this.ManagegPromotion.Location = new System.Drawing.Point(446, 22);
            this.ManagegPromotion.Name = "ManagegPromotion";
            this.ManagegPromotion.Size = new System.Drawing.Size(152, 173);
            this.ManagegPromotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManagegPromotion.TabIndex = 22;
            this.ManagegPromotion.TabStop = false;
            this.ManagegPromotion.Click += new System.EventHandler(this.ManagegPromotion_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(662, 257);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(152, 170);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Close.TabIndex = 21;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BranchImportBallot
            // 
            this.BranchImportBallot.Image = ((System.Drawing.Image)(resources.GetObject("BranchImportBallot.Image")));
            this.BranchImportBallot.Location = new System.Drawing.Point(29, 257);
            this.BranchImportBallot.Name = "BranchImportBallot";
            this.BranchImportBallot.Size = new System.Drawing.Size(152, 170);
            this.BranchImportBallot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BranchImportBallot.TabIndex = 20;
            this.BranchImportBallot.TabStop = false;
            this.BranchImportBallot.Click += new System.EventHandler(this.BranchImportBallot_Click);
            // 
            // HeadquarterImportBallot
            // 
            this.HeadquarterImportBallot.Image = ((System.Drawing.Image)(resources.GetObject("HeadquarterImportBallot.Image")));
            this.HeadquarterImportBallot.Location = new System.Drawing.Point(662, 22);
            this.HeadquarterImportBallot.Name = "HeadquarterImportBallot";
            this.HeadquarterImportBallot.Size = new System.Drawing.Size(152, 173);
            this.HeadquarterImportBallot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadquarterImportBallot.TabIndex = 19;
            this.HeadquarterImportBallot.TabStop = false;
            this.HeadquarterImportBallot.Click += new System.EventHandler(this.HeadquarterImportBallot_Click);
            // 
            // ManageBill
            // 
            this.ManageBill.Image = ((System.Drawing.Image)(resources.GetObject("ManageBill.Image")));
            this.ManageBill.Location = new System.Drawing.Point(235, 257);
            this.ManageBill.Name = "ManageBill";
            this.ManageBill.Size = new System.Drawing.Size(152, 170);
            this.ManageBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageBill.TabIndex = 18;
            this.ManageBill.TabStop = false;
            this.ManageBill.Click += new System.EventHandler(this.ManageBill_Click);
            // 
            // ManageSalesStatustic
            // 
            this.ManageSalesStatustic.Image = ((System.Drawing.Image)(resources.GetObject("ManageSalesStatustic.Image")));
            this.ManageSalesStatustic.Location = new System.Drawing.Point(454, 257);
            this.ManageSalesStatustic.Name = "ManageSalesStatustic";
            this.ManageSalesStatustic.Size = new System.Drawing.Size(152, 170);
            this.ManageSalesStatustic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageSalesStatustic.TabIndex = 17;
            this.ManageSalesStatustic.TabStop = false;
            this.ManageSalesStatustic.Click += new System.EventHandler(this.ManageSalesStatustic_Click);
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 483);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ManageProduct);
            this.Controls.Add(this.ManagePriceHistory);
            this.Controls.Add(this.ManagegPromotion);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.BranchImportBallot);
            this.Controls.Add(this.HeadquarterImportBallot);
            this.Controls.Add(this.ManageBill);
            this.Controls.Add(this.ManageSalesStatustic);
            this.Name = "GUI_Home";
            this.Text = "GUI_Home";
            ((System.ComponentModel.ISupportInitialize)(this.ManageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePriceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagegPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadquarterImportBallot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageSalesStatustic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox ManageProduct;
        private System.Windows.Forms.PictureBox ManagePriceHistory;
        private System.Windows.Forms.PictureBox ManagegPromotion;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox BranchImportBallot;
        private System.Windows.Forms.PictureBox HeadquarterImportBallot;
        private System.Windows.Forms.PictureBox ManageBill;
        private System.Windows.Forms.PictureBox ManageSalesStatustic;
    }
}