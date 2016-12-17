namespace WindowsFormsApplication.ManagePromotion
{
    partial class GUI_InsertPromotion
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
            this.lblEnDay = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblProContent = new System.Windows.Forms.Label();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblHinh = new System.Windows.Forms.Label();
            this.txtPromotionImage = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cboProductCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(351, 183);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDay.TabIndex = 30;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(351, 109);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDay.TabIndex = 29;
            // 
            // txtPromotionContent
            // 
            this.txtPromotionContent.Location = new System.Drawing.Point(33, 212);
            this.txtPromotionContent.Multiline = true;
            this.txtPromotionContent.Name = "txtPromotionContent";
            this.txtPromotionContent.Size = new System.Drawing.Size(249, 40);
            this.txtPromotionContent.TabIndex = 28;
            // 
            // txtPromotionPrice
            // 
            this.txtPromotionPrice.Location = new System.Drawing.Point(124, 149);
            this.txtPromotionPrice.Name = "txtPromotionPrice";
            this.txtPromotionPrice.Size = new System.Drawing.Size(158, 20);
            this.txtPromotionPrice.TabIndex = 27;
            // 
            // lblEnDay
            // 
            this.lblEnDay.AutoSize = true;
            this.lblEnDay.Location = new System.Drawing.Point(348, 149);
            this.lblEnDay.Name = "lblEnDay";
            this.lblEnDay.Size = new System.Drawing.Size(96, 13);
            this.lblEnDay.TabIndex = 24;
            this.lblEnDay.Text = "Thời gian kết thúc:";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Location = new System.Drawing.Point(348, 74);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(94, 13);
            this.lblStartDay.TabIndex = 23;
            this.lblStartDay.Text = "Thời gian bắt đầu:";
            // 
            // lblProContent
            // 
            this.lblProContent.AutoSize = true;
            this.lblProContent.Location = new System.Drawing.Point(30, 190);
            this.lblProContent.Name = "lblProContent";
            this.lblProContent.Size = new System.Drawing.Size(110, 13);
            this.lblProContent.TabIndex = 22;
            this.lblProContent.Text = "Nội dung khuyến mãi:";
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(30, 156);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(83, 13);
            this.lblProPrice.TabIndex = 21;
            this.lblProPrice.Text = "Giá khuyến mãi:";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(30, 74);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(74, 13);
            this.lblProductCode.TabIndex = 20;
            this.lblProductCode.Text = "Mã sản phẩm:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(131, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Thêm thông tin khuyến mãi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 29);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.clickSave);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(392, 224);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(77, 28);
            this.btnCancle.TabIndex = 33;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.clickCacel);
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Location = new System.Drawing.Point(30, 115);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(32, 13);
            this.lblHinh.TabIndex = 34;
            this.lblHinh.Text = "Hình:";
            // 
            // txtPromotionImage
            // 
            this.txtPromotionImage.Location = new System.Drawing.Point(124, 109);
            this.txtPromotionImage.Name = "txtPromotionImage";
            this.txtPromotionImage.Size = new System.Drawing.Size(104, 20);
            this.txtPromotionImage.TabIndex = 35;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(227, 107);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(55, 23);
            this.btnChoose.TabIndex = 36;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // cboProductCode
            // 
            this.cboProductCode.FormattingEnabled = true;
            this.cboProductCode.Location = new System.Drawing.Point(124, 71);
            this.cboProductCode.Name = "cboProductCode";
            this.cboProductCode.Size = new System.Drawing.Size(158, 21);
            this.cboProductCode.TabIndex = 37;
            // 
            // GUI_InsertPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 264);
            this.Controls.Add(this.cboProductCode);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtPromotionImage);
            this.Controls.Add(this.lblHinh);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.txtPromotionContent);
            this.Controls.Add(this.txtPromotionPrice);
            this.Controls.Add(this.lblEnDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblProContent);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_InsertPromotion";
            this.Text = "GUI_InsertPromotion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.TextBox txtPromotionContent;
        private System.Windows.Forms.TextBox txtPromotionPrice;
        private System.Windows.Forms.Label lblEnDay;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblProContent;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblHinh;
        private System.Windows.Forms.TextBox txtPromotionImage;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ComboBox cboProductCode;
    }
}