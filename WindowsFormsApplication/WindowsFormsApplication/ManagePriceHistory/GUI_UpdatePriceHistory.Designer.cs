namespace WindowsFormsApplication.ManagePriceHistory
{
    partial class GUI_UpdatePriceHistory
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
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPriceHistory = new System.Windows.Forms.TextBox();
            this.txtProductNamePriceHistory = new System.Windows.Forms.TextBox();
            this.txtProductIDPriceHistory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(93, 163);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(210, 20);
            this.txtNewPrice.TabIndex = 36;
           
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Giá bán mới: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(93, 194);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 20);
            this.dtpDate.TabIndex = 32;
            // 
            // txtPriceHistory
            // 
            this.txtPriceHistory.Enabled = false;
            this.txtPriceHistory.Location = new System.Drawing.Point(93, 127);
            this.txtPriceHistory.Name = "txtPriceHistory";
            this.txtPriceHistory.ReadOnly = true;
            this.txtPriceHistory.Size = new System.Drawing.Size(210, 20);
            this.txtPriceHistory.TabIndex = 31;
            // 
            // txtProductNamePriceHistory
            // 
            this.txtProductNamePriceHistory.Enabled = false;
            this.txtProductNamePriceHistory.Location = new System.Drawing.Point(93, 92);
            this.txtProductNamePriceHistory.Name = "txtProductNamePriceHistory";
            this.txtProductNamePriceHistory.ReadOnly = true;
            this.txtProductNamePriceHistory.Size = new System.Drawing.Size(210, 20);
            this.txtProductNamePriceHistory.TabIndex = 30;
            // 
            // txtProductIDPriceHistory
            // 
            this.txtProductIDPriceHistory.Enabled = false;
            this.txtProductIDPriceHistory.Location = new System.Drawing.Point(93, 54);
            this.txtProductIDPriceHistory.Name = "txtProductIDPriceHistory";
            this.txtProductIDPriceHistory.ReadOnly = true;
            this.txtProductIDPriceHistory.Size = new System.Drawing.Size(210, 20);
            this.txtProductIDPriceHistory.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày hiệu lực:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giá bán cũ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "CẬP NHẬT LỊCH SỬ GIÁ";
            // 
            // GUI_UpdatePriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 306);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPriceHistory);
            this.Controls.Add(this.txtProductNamePriceHistory);
            this.Controls.Add(this.txtProductIDPriceHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_UpdatePriceHistory";
            this.Text = "CẬP NHẬT LỊCH SỬ GIÁ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPriceHistory;
        private System.Windows.Forms.TextBox txtProductNamePriceHistory;
        private System.Windows.Forms.TextBox txtProductIDPriceHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}