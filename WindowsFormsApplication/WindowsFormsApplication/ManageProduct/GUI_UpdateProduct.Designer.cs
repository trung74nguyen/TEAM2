namespace WindowsFormsApplication.ManageProduct
{
    partial class GUI_UpdateProduct
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboSupplierCode = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTypeCode = new System.Windows.Forms.ComboBox();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.clickCancel);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 261);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.clickUpdate);
            // 
            // cboSupplierCode
            // 
            this.cboSupplierCode.FormattingEnabled = true;
            this.cboSupplierCode.Location = new System.Drawing.Point(152, 217);
            this.cboSupplierCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSupplierCode.Name = "cboSupplierCode";
            this.cboSupplierCode.Size = new System.Drawing.Size(209, 24);
            this.cboSupplierCode.TabIndex = 58;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(308, 124);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(55, 28);
            this.btnSelect.TabIndex = 57;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(152, 85);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(209, 22);
            this.txtProductName.TabIndex = 56;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(152, 127);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(147, 22);
            this.txtImage.TabIndex = 55;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(27, 220);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(100, 17);
            this.lblSupplier.TabIndex = 53;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(27, 130);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(69, 17);
            this.lblImage.TabIndex = 52;
            this.lblImage.Text = "Hình ảnh:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(27, 89);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 17);
            this.lblProductName.TabIndex = 51;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 38);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Cập nhật sản phẩm";
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.FormattingEnabled = true;
            this.cboTypeCode.Location = new System.Drawing.Point(152, 171);
            this.cboTypeCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(209, 24);
            this.cboTypeCode.TabIndex = 62;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Location = new System.Drawing.Point(27, 175);
            this.lblTypeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(105, 17);
            this.lblTypeCode.TabIndex = 61;
            this.lblTypeCode.Text = "Loại sản phẩm:";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // GUI_UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 299);
            this.Controls.Add(this.cboTypeCode);
            this.Controls.Add(this.lblTypeCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboSupplierCode);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_UpdateProduct";
            this.Text = "GUI_UpdateProduct";
            this.Load += new System.EventHandler(this.showUpdateProductForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboSupplierCode;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTypeCode;
        private System.Windows.Forms.Label lblTypeCode;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}