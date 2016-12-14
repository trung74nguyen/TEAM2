namespace WindowsFormsApplication.ManageProduct
{
    partial class GUI_InsertProduct
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboTypeCode = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboSupplierCode = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.clickCancel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.clickSave);
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.FormattingEnabled = true;
            this.cboTypeCode.Location = new System.Drawing.Point(114, 123);
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(158, 21);
            this.cboTypeCode.TabIndex = 70;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(231, 86);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(41, 23);
            this.btnSelect.TabIndex = 69;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(114, 54);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 20);
            this.txtProductName.TabIndex = 68;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(114, 88);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(111, 20);
            this.txtImage.TabIndex = 67;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Location = new System.Drawing.Point(20, 126);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(79, 13);
            this.lblTypeCode.TabIndex = 65;
            this.lblTypeCode.Text = "Loại sản phẩm:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(20, 91);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(53, 13);
            this.lblImage.TabIndex = 64;
            this.lblImage.Text = "Hình ảnh:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 57);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 63;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 31);
            this.lblTitle.TabIndex = 61;
            this.lblTitle.Text = "Thêm sản phẩm";
            // 
            // cboSupplierCode
            // 
            this.cboSupplierCode.FormattingEnabled = true;
            this.cboSupplierCode.Location = new System.Drawing.Point(114, 159);
            this.cboSupplierCode.Name = "cboSupplierCode";
            this.cboSupplierCode.Size = new System.Drawing.Size(158, 21);
            this.cboSupplierCode.TabIndex = 74;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(20, 162);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(78, 13);
            this.lblSupplier.TabIndex = 73;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // GUI_InsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 233);
            this.Controls.Add(this.cboSupplierCode);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboTypeCode);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblTypeCode);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_InsertProduct";
            this.Text = "GUI_InsertProduct";
            this.Load += new System.EventHandler(this.showInsertProductForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboTypeCode;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblTypeCode;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboSupplierCode;
        private System.Windows.Forms.Label lblSupplier;
    }
}