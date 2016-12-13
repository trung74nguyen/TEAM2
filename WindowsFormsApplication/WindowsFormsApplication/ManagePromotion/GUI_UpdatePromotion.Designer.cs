namespace WindowsFormsApplication.ManagePromotion
{
    partial class GUI_UpdatePromotion
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
            this.dtpEndDayUp = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDayUp = new System.Windows.Forms.DateTimePicker();
            this.txtProConUp = new System.Windows.Forms.TextBox();
            this.txtProPriceUpd = new System.Windows.Forms.TextBox();
            this.txtProductCodeUp = new System.Windows.Forms.TextBox();
            this.txtProCodeUp = new System.Windows.Forms.TextBox();
            this.lblEnDay = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblProContent = new System.Windows.Forms.Label();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEndDayUp
            // 
            this.dtpEndDayUp.Location = new System.Drawing.Point(351, 183);
            this.dtpEndDayUp.Name = "dtpEndDayUp";
            this.dtpEndDayUp.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDayUp.TabIndex = 43;
            // 
            // dtpStartDayUp
            // 
            this.dtpStartDayUp.Location = new System.Drawing.Point(351, 109);
            this.dtpStartDayUp.Name = "dtpStartDayUp";
            this.dtpStartDayUp.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDayUp.TabIndex = 42;
            // 
            // txtProConUp
            // 
            this.txtProConUp.Location = new System.Drawing.Point(33, 232);
            this.txtProConUp.Multiline = true;
            this.txtProConUp.Name = "txtProConUp";
            this.txtProConUp.Size = new System.Drawing.Size(249, 31);
            this.txtProConUp.TabIndex = 41;
            // 
            // txtProPriceUpd
            // 
            this.txtProPriceUpd.Location = new System.Drawing.Point(124, 176);
            this.txtProPriceUpd.Name = "txtProPriceUpd";
            this.txtProPriceUpd.Size = new System.Drawing.Size(158, 20);
            this.txtProPriceUpd.TabIndex = 40;
            // 
            // txtProductCodeUp
            // 
            this.txtProductCodeUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProductCodeUp.Location = new System.Drawing.Point(124, 109);
            this.txtProductCodeUp.Name = "txtProductCodeUp";
            this.txtProductCodeUp.ReadOnly = true;
            this.txtProductCodeUp.Size = new System.Drawing.Size(158, 20);
            this.txtProductCodeUp.TabIndex = 39;
            // 
            // txtProCodeUp
            // 
            this.txtProCodeUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProCodeUp.Location = new System.Drawing.Point(124, 74);
            this.txtProCodeUp.Name = "txtProCodeUp";
            this.txtProCodeUp.ReadOnly = true;
            this.txtProCodeUp.Size = new System.Drawing.Size(158, 20);
            this.txtProCodeUp.TabIndex = 38;
            // 
            // lblEnDay
            // 
            this.lblEnDay.AutoSize = true;
            this.lblEnDay.Location = new System.Drawing.Point(348, 149);
            this.lblEnDay.Name = "lblEnDay";
            this.lblEnDay.Size = new System.Drawing.Size(96, 13);
            this.lblEnDay.TabIndex = 37;
            this.lblEnDay.Text = "Thời gian kết thúc:";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Location = new System.Drawing.Point(348, 74);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(94, 13);
            this.lblStartDay.TabIndex = 36;
            this.lblStartDay.Text = "Thời gian bắt đầu:";
            // 
            // lblProContent
            // 
            this.lblProContent.AutoSize = true;
            this.lblProContent.Location = new System.Drawing.Point(30, 206);
            this.lblProContent.Name = "lblProContent";
            this.lblProContent.Size = new System.Drawing.Size(110, 13);
            this.lblProContent.TabIndex = 35;
            this.lblProContent.Text = "Nội dung khuyến mãi:";
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(30, 183);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(83, 13);
            this.lblProPrice.TabIndex = 34;
            this.lblProPrice.Text = "Giá khuyến mãi:";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(30, 116);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(74, 13);
            this.lblProductCode.TabIndex = 33;
            this.lblProductCode.Text = "Mã sản phẩm:";
            // 
            // lblProCode
            // 
            this.lblProCode.AutoSize = true;
            this.lblProCode.Location = new System.Drawing.Point(30, 81);
            this.lblProCode.Name = "lblProCode";
            this.lblProCode.Size = new System.Drawing.Size(82, 13);
            this.lblProCode.TabIndex = 32;
            this.lblProCode.Text = "Mã khuyến mãi:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(131, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 31);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Cập nhật thông tin khuyến mãi";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(392, 224);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(77, 28);
            this.btnCancle.TabIndex = 45;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 29);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.clickUpdate);
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImage.Location = new System.Drawing.Point(124, 142);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(158, 20);
            this.txtImage.TabIndex = 47;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(30, 149);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(29, 13);
            this.lblImage.TabIndex = 46;
            this.lblImage.Text = "Hình";
            // 
            // GUI_UpdatePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 275);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEndDayUp);
            this.Controls.Add(this.dtpStartDayUp);
            this.Controls.Add(this.txtProConUp);
            this.Controls.Add(this.txtProPriceUpd);
            this.Controls.Add(this.txtProductCodeUp);
            this.Controls.Add(this.txtProCodeUp);
            this.Controls.Add(this.lblEnDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblProContent);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblProCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_UpdatePromotion";
            this.Text = "GUI_UpdatePromotion";
            this.Load += new System.EventHandler(this.showUpdatePromotionForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDayUp;
        private System.Windows.Forms.DateTimePicker dtpStartDayUp;
        private System.Windows.Forms.TextBox txtProConUp;
        private System.Windows.Forms.TextBox txtProPriceUpd;
        private System.Windows.Forms.TextBox txtProductCodeUp;
        private System.Windows.Forms.TextBox txtProCodeUp;
        private System.Windows.Forms.Label lblEnDay;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblProContent;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImage;
    }
}