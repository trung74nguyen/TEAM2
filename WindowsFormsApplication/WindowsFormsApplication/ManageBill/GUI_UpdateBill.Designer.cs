namespace WindowsFormsApplication.ManageBill
{
    partial class GUI_UpdateBill
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
            this.btnSaveUp = new System.Windows.Forms.Button();
            this.btnCancelUp = new System.Windows.Forms.Button();
            this.txtExcessCashUp = new System.Windows.Forms.TextBox();
            this.lblExcessCashUp = new System.Windows.Forms.Label();
            this.txtGuestMoneyUp = new System.Windows.Forms.TextBox();
            this.txtTotalUp = new System.Windows.Forms.TextBox();
            this.lblGuestMoneyUp = new System.Windows.Forms.Label();
            this.lblTotalUp = new System.Windows.Forms.Label();
            this.lblUpUp = new System.Windows.Forms.LinkLabel();
            this.lstManageBillUp = new System.Windows.Forms.DataGridView();
            this.txtHourUp = new System.Windows.Forms.TextBox();
            this.lblHourUp = new System.Windows.Forms.Label();
            this.txtDayUp = new System.Windows.Forms.TextBox();
            this.txtCodeUp = new System.Windows.Forms.TextBox();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.lblDayUp = new System.Windows.Forms.Label();
            this.lblCodeUp = new System.Windows.Forms.Label();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveUp
            // 
            this.btnSaveUp.Location = new System.Drawing.Point(502, 416);
            this.btnSaveUp.Name = "btnSaveUp";
            this.btnSaveUp.Size = new System.Drawing.Size(75, 30);
            this.btnSaveUp.TabIndex = 73;
            this.btnSaveUp.Text = "Lưu";
            this.btnSaveUp.UseVisualStyleBackColor = true;
            // 
            // btnCancelUp
            // 
            this.btnCancelUp.Location = new System.Drawing.Point(583, 416);
            this.btnCancelUp.Name = "btnCancelUp";
            this.btnCancelUp.Size = new System.Drawing.Size(75, 30);
            this.btnCancelUp.TabIndex = 72;
            this.btnCancelUp.Text = "Hủy";
            this.btnCancelUp.UseVisualStyleBackColor = true;
            // 
            // txtExcessCashUp
            // 
            this.txtExcessCashUp.BackColor = System.Drawing.Color.White;
            this.txtExcessCashUp.Location = new System.Drawing.Point(471, 383);
            this.txtExcessCashUp.Name = "txtExcessCashUp";
            this.txtExcessCashUp.ReadOnly = true;
            this.txtExcessCashUp.Size = new System.Drawing.Size(129, 20);
            this.txtExcessCashUp.TabIndex = 71;
            this.txtExcessCashUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExcessCashUp
            // 
            this.lblExcessCashUp.AutoSize = true;
            this.lblExcessCashUp.Location = new System.Drawing.Point(379, 390);
            this.lblExcessCashUp.Name = "lblExcessCashUp";
            this.lblExcessCashUp.Size = new System.Drawing.Size(46, 13);
            this.lblExcessCashUp.TabIndex = 70;
            this.lblExcessCashUp.Text = "Tiền dư:";
            // 
            // txtGuestMoneyUp
            // 
            this.txtGuestMoneyUp.BackColor = System.Drawing.Color.White;
            this.txtGuestMoneyUp.Location = new System.Drawing.Point(471, 353);
            this.txtGuestMoneyUp.Name = "txtGuestMoneyUp";
            this.txtGuestMoneyUp.ReadOnly = true;
            this.txtGuestMoneyUp.Size = new System.Drawing.Size(129, 20);
            this.txtGuestMoneyUp.TabIndex = 69;
            this.txtGuestMoneyUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalUp
            // 
            this.txtTotalUp.Location = new System.Drawing.Point(471, 319);
            this.txtTotalUp.Name = "txtTotalUp";
            this.txtTotalUp.Size = new System.Drawing.Size(129, 20);
            this.txtTotalUp.TabIndex = 68;
            this.txtTotalUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuestMoneyUp
            // 
            this.lblGuestMoneyUp.AutoSize = true;
            this.lblGuestMoneyUp.Location = new System.Drawing.Point(379, 360);
            this.lblGuestMoneyUp.Name = "lblGuestMoneyUp";
            this.lblGuestMoneyUp.Size = new System.Drawing.Size(86, 13);
            this.lblGuestMoneyUp.TabIndex = 67;
            this.lblGuestMoneyUp.Text = "Tiền khách đưa:";
            // 
            // lblTotalUp
            // 
            this.lblTotalUp.AutoSize = true;
            this.lblTotalUp.Location = new System.Drawing.Point(379, 326);
            this.lblTotalUp.Name = "lblTotalUp";
            this.lblTotalUp.Size = new System.Drawing.Size(55, 13);
            this.lblTotalUp.TabIndex = 66;
            this.lblTotalUp.Text = "Tổng tiền:";
            // 
            // lblUpUp
            // 
            this.lblUpUp.AutoSize = true;
            this.lblUpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpUp.Location = new System.Drawing.Point(632, 160);
            this.lblUpUp.Name = "lblUpUp";
            this.lblUpUp.Size = new System.Drawing.Size(32, 16);
            this.lblUpUp.TabIndex = 65;
            this.lblUpUp.TabStop = true;
            this.lblUpUp.Text = "Sửa";
            // 
            // lstManageBillUp
            // 
            this.lstManageBillUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillUp.Location = new System.Drawing.Point(28, 149);
            this.lstManageBillUp.Name = "lstManageBillUp";
            this.lstManageBillUp.Size = new System.Drawing.Size(572, 150);
            this.lstManageBillUp.TabIndex = 64;
            // 
            // txtHourUp
            // 
            this.txtHourUp.Location = new System.Drawing.Point(521, 110);
            this.txtHourUp.Name = "txtHourUp";
            this.txtHourUp.Size = new System.Drawing.Size(137, 20);
            this.txtHourUp.TabIndex = 63;
            this.txtHourUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourUp
            // 
            this.lblHourUp.AutoSize = true;
            this.lblHourUp.Location = new System.Drawing.Point(468, 116);
            this.lblHourUp.Name = "lblHourUp";
            this.lblHourUp.Size = new System.Drawing.Size(47, 13);
            this.lblHourUp.TabIndex = 62;
            this.lblHourUp.Text = "Giờ bán:";
            // 
            // txtDayUp
            // 
            this.txtDayUp.Location = new System.Drawing.Point(330, 110);
            this.txtDayUp.Name = "txtDayUp";
            this.txtDayUp.Size = new System.Drawing.Size(101, 20);
            this.txtDayUp.TabIndex = 61;
            this.txtDayUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodeUp
            // 
            this.txtCodeUp.BackColor = System.Drawing.Color.White;
            this.txtCodeUp.Location = new System.Drawing.Point(87, 106);
            this.txtCodeUp.Name = "txtCodeUp";
            this.txtCodeUp.ReadOnly = true;
            this.txtCodeUp.Size = new System.Drawing.Size(158, 20);
            this.txtCodeUp.TabIndex = 60;
            this.txtCodeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameUp
            // 
            this.txtNameUp.Location = new System.Drawing.Point(87, 68);
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.Size = new System.Drawing.Size(158, 20);
            this.txtNameUp.TabIndex = 59;
            this.txtNameUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDayUp
            // 
            this.lblDayUp.AutoSize = true;
            this.lblDayUp.Location = new System.Drawing.Point(268, 113);
            this.lblDayUp.Name = "lblDayUp";
            this.lblDayUp.Size = new System.Drawing.Size(56, 13);
            this.lblDayUp.TabIndex = 58;
            this.lblDayUp.Text = "Ngày bán:";
            // 
            // lblCodeUp
            // 
            this.lblCodeUp.AutoSize = true;
            this.lblCodeUp.Location = new System.Drawing.Point(25, 113);
            this.lblCodeUp.Name = "lblCodeUp";
            this.lblCodeUp.Size = new System.Drawing.Size(52, 13);
            this.lblCodeUp.TabIndex = 57;
            this.lblCodeUp.Text = "Số phiếu:";
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Location = new System.Drawing.Point(25, 75);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(56, 13);
            this.lblNameUp.TabIndex = 56;
            this.lblNameUp.Text = "Thu ngân:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(237, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 31);
            this.lblTitle.TabIndex = 55;
            this.lblTitle.Text = "Cập nhật hóa đơn";
            // 
            // GUI_UpdateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 458);
            this.Controls.Add(this.btnSaveUp);
            this.Controls.Add(this.btnCancelUp);
            this.Controls.Add(this.txtExcessCashUp);
            this.Controls.Add(this.lblExcessCashUp);
            this.Controls.Add(this.txtGuestMoneyUp);
            this.Controls.Add(this.txtTotalUp);
            this.Controls.Add(this.lblGuestMoneyUp);
            this.Controls.Add(this.lblTotalUp);
            this.Controls.Add(this.lblUpUp);
            this.Controls.Add(this.lstManageBillUp);
            this.Controls.Add(this.txtHourUp);
            this.Controls.Add(this.lblHourUp);
            this.Controls.Add(this.txtDayUp);
            this.Controls.Add(this.txtCodeUp);
            this.Controls.Add(this.txtNameUp);
            this.Controls.Add(this.lblDayUp);
            this.Controls.Add(this.lblCodeUp);
            this.Controls.Add(this.lblNameUp);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_UpdateBill";
            this.Text = "GUI_UpdateBill";
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUp;
        private System.Windows.Forms.Button btnCancelUp;
        private System.Windows.Forms.TextBox txtExcessCashUp;
        private System.Windows.Forms.Label lblExcessCashUp;
        private System.Windows.Forms.TextBox txtGuestMoneyUp;
        private System.Windows.Forms.TextBox txtTotalUp;
        private System.Windows.Forms.Label lblGuestMoneyUp;
        private System.Windows.Forms.Label lblTotalUp;
        private System.Windows.Forms.LinkLabel lblUpUp;
        private System.Windows.Forms.DataGridView lstManageBillUp;
        private System.Windows.Forms.TextBox txtHourUp;
        private System.Windows.Forms.Label lblHourUp;
        private System.Windows.Forms.TextBox txtDayUp;
        private System.Windows.Forms.TextBox txtCodeUp;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.Label lblDayUp;
        private System.Windows.Forms.Label lblCodeUp;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.Label lblTitle;
    }
}