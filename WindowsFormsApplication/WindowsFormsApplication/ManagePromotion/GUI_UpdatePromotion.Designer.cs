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
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.txtPromotionContent = new System.Windows.Forms.TextBox();
            this.txtPromotionPrice = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtPromotionCode = new System.Windows.Forms.TextBox();
            this.lblEnDay = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblProContent = new System.Windows.Forms.Label();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtPromotionImage = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(101, 241);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(160, 20);
            this.dtpEndDay.TabIndex = 43;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(101, 206);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(160, 20);
            this.dtpStartDay.TabIndex = 42;
            // 
            // txtPromotionContent
            // 
            this.txtPromotionContent.Location = new System.Drawing.Point(285, 66);
            this.txtPromotionContent.Multiline = true;
            this.txtPromotionContent.Name = "txtPromotionContent";
            this.txtPromotionContent.Size = new System.Drawing.Size(210, 176);
            this.txtPromotionContent.TabIndex = 41;
            // 
            // txtPromotionPrice
            // 
            this.txtPromotionPrice.Location = new System.Drawing.Point(101, 171);
            this.txtPromotionPrice.Name = "txtPromotionPrice";
            this.txtPromotionPrice.Size = new System.Drawing.Size(160, 20);
            this.txtPromotionPrice.TabIndex = 40;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProductCode.Location = new System.Drawing.Point(101, 101);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(160, 20);
            this.txtProductCode.TabIndex = 39;
            // 
            // txtPromotionCode
            // 
            this.txtPromotionCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPromotionCode.Location = new System.Drawing.Point(101, 66);
            this.txtPromotionCode.Name = "txtPromotionCode";
            this.txtPromotionCode.ReadOnly = true;
            this.txtPromotionCode.Size = new System.Drawing.Size(160, 20);
            this.txtPromotionCode.TabIndex = 38;
            // 
            // lblEnDay
            // 
            this.lblEnDay.AutoSize = true;
            this.lblEnDay.Location = new System.Drawing.Point(16, 242);
            this.lblEnDay.Name = "lblEnDay";
            this.lblEnDay.Size = new System.Drawing.Size(77, 13);
            this.lblEnDay.TabIndex = 37;
            this.lblEnDay.Text = "Ngày kết thúc:";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Location = new System.Drawing.Point(20, 208);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(75, 13);
            this.lblStartDay.TabIndex = 36;
            this.lblStartDay.Text = "Ngày bắt đầu:";
            // 
            // lblProContent
            // 
            this.lblProContent.AutoSize = true;
            this.lblProContent.Location = new System.Drawing.Point(340, 50);
            this.lblProContent.Name = "lblProContent";
            this.lblProContent.Size = new System.Drawing.Size(110, 13);
            this.lblProContent.TabIndex = 35;
            this.lblProContent.Text = "Nội dung khuyến mãi:";
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(12, 174);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(83, 13);
            this.lblProPrice.TabIndex = 34;
            this.lblProPrice.Text = "Giá khuyến mãi:";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(21, 104);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(74, 13);
            this.lblProductCode.TabIndex = 33;
            this.lblProductCode.Text = "Mã sản phẩm:";
            // 
            // lblProCode
            // 
            this.lblProCode.AutoSize = true;
            this.lblProCode.Location = new System.Drawing.Point(13, 69);
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
            this.lblTitle.Location = new System.Drawing.Point(1, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 31);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN KHUYẾN MÃI";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.clickCancel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.clickUpdate);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(9, 140);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(86, 13);
            this.lblImage.TabIndex = 46;
            this.lblImage.Text = "Ảnh khuyến mãi:";
            // 
            // txtPromotionImage
            // 
            this.txtPromotionImage.Location = new System.Drawing.Point(101, 136);
            this.txtPromotionImage.Name = "txtPromotionImage";
            this.txtPromotionImage.Size = new System.Drawing.Size(120, 20);
            this.txtPromotionImage.TabIndex = 47;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(221, 135);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(40, 23);
            this.btnChoose.TabIndex = 48;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // GUI_UpdatePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 296);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtPromotionImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.txtPromotionContent);
            this.Controls.Add(this.txtPromotionPrice);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtPromotionCode);
            this.Controls.Add(this.lblEnDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblProContent);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblProCode);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_UpdatePromotion";
            this.Text = "CẬP NHẬT THÔNG TIN KHUYẾN MÃI";
            this.Load += new System.EventHandler(this.loadDataPromotionToForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.TextBox txtPromotionContent;
        private System.Windows.Forms.TextBox txtPromotionPrice;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtPromotionCode;
        private System.Windows.Forms.Label lblEnDay;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblProContent;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtPromotionImage;
        private System.Windows.Forms.Button btnChoose;
    }
}