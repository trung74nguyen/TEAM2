namespace WindowsFormsApplication.ManageBill
{
    partial class GUI_InsertBill
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
            this.btnSaveIn = new System.Windows.Forms.Button();
            this.btnCancelIn = new System.Windows.Forms.Button();
            this.txtExcessCashIn = new System.Windows.Forms.TextBox();
            this.lblExcessCashIn = new System.Windows.Forms.Label();
            this.txtGuestMoneyIn = new System.Windows.Forms.TextBox();
            this.txtTotalIn = new System.Windows.Forms.TextBox();
            this.lblGuestMoneyIn = new System.Windows.Forms.Label();
            this.lblTotalIn = new System.Windows.Forms.Label();
            this.lblUpIn = new System.Windows.Forms.LinkLabel();
            this.lstManageBillIn = new System.Windows.Forms.DataGridView();
            this.txtHourIn = new System.Windows.Forms.TextBox();
            this.lblHourIn = new System.Windows.Forms.Label();
            this.txtDayIn = new System.Windows.Forms.TextBox();
            this.txtCodeIn = new System.Windows.Forms.TextBox();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.lblDayIn = new System.Windows.Forms.Label();
            this.lblCodeIn = new System.Windows.Forms.Label();
            this.lblNameIn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtPOS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillIn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveIn
            // 
            this.btnSaveIn.Location = new System.Drawing.Point(502, 416);
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.Size = new System.Drawing.Size(75, 30);
            this.btnSaveIn.TabIndex = 54;
            this.btnSaveIn.Text = "Lưu";
            this.btnSaveIn.UseVisualStyleBackColor = true;
            this.btnSaveIn.Click += new System.EventHandler(this.btnSaveIn_Click);
            // 
            // btnCancelIn
            // 
            this.btnCancelIn.Location = new System.Drawing.Point(583, 416);
            this.btnCancelIn.Name = "btnCancelIn";
            this.btnCancelIn.Size = new System.Drawing.Size(75, 30);
            this.btnCancelIn.TabIndex = 53;
            this.btnCancelIn.Text = "Hủy";
            this.btnCancelIn.UseVisualStyleBackColor = true;
            // 
            // txtExcessCashIn
            // 
            this.txtExcessCashIn.BackColor = System.Drawing.Color.White;
            this.txtExcessCashIn.Location = new System.Drawing.Point(471, 383);
            this.txtExcessCashIn.Name = "txtExcessCashIn";
            this.txtExcessCashIn.ReadOnly = true;
            this.txtExcessCashIn.Size = new System.Drawing.Size(129, 20);
            this.txtExcessCashIn.TabIndex = 52;
            this.txtExcessCashIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExcessCashIn
            // 
            this.lblExcessCashIn.AutoSize = true;
            this.lblExcessCashIn.Location = new System.Drawing.Point(379, 390);
            this.lblExcessCashIn.Name = "lblExcessCashIn";
            this.lblExcessCashIn.Size = new System.Drawing.Size(46, 13);
            this.lblExcessCashIn.TabIndex = 51;
            this.lblExcessCashIn.Text = "Tiền dư:";
            // 
            // txtGuestMoneyIn
            // 
            this.txtGuestMoneyIn.BackColor = System.Drawing.Color.White;
            this.txtGuestMoneyIn.Location = new System.Drawing.Point(471, 353);
            this.txtGuestMoneyIn.Name = "txtGuestMoneyIn";
            this.txtGuestMoneyIn.Size = new System.Drawing.Size(129, 20);
            this.txtGuestMoneyIn.TabIndex = 50;
            this.txtGuestMoneyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalIn
            // 
            this.txtTotalIn.Location = new System.Drawing.Point(471, 319);
            this.txtTotalIn.Name = "txtTotalIn";
            this.txtTotalIn.ReadOnly = true;
            this.txtTotalIn.Size = new System.Drawing.Size(129, 20);
            this.txtTotalIn.TabIndex = 49;
            this.txtTotalIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuestMoneyIn
            // 
            this.lblGuestMoneyIn.AutoSize = true;
            this.lblGuestMoneyIn.Location = new System.Drawing.Point(379, 360);
            this.lblGuestMoneyIn.Name = "lblGuestMoneyIn";
            this.lblGuestMoneyIn.Size = new System.Drawing.Size(86, 13);
            this.lblGuestMoneyIn.TabIndex = 48;
            this.lblGuestMoneyIn.Text = "Tiền khách đưa:";
            // 
            // lblTotalIn
            // 
            this.lblTotalIn.AutoSize = true;
            this.lblTotalIn.Location = new System.Drawing.Point(379, 326);
            this.lblTotalIn.Name = "lblTotalIn";
            this.lblTotalIn.Size = new System.Drawing.Size(55, 13);
            this.lblTotalIn.TabIndex = 47;
            this.lblTotalIn.Text = "Tổng tiền:";
            // 
            // lblUpIn
            // 
            this.lblUpIn.AutoSize = true;
            this.lblUpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpIn.Location = new System.Drawing.Point(632, 160);
            this.lblUpIn.Name = "lblUpIn";
            this.lblUpIn.Size = new System.Drawing.Size(32, 16);
            this.lblUpIn.TabIndex = 46;
            this.lblUpIn.TabStop = true;
            this.lblUpIn.Text = "Sửa";
            this.lblUpIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUpIn_LinkClicked);
            // 
            // lstManageBillIn
            // 
            this.lstManageBillIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillIn.Location = new System.Drawing.Point(28, 149);
            this.lstManageBillIn.Name = "lstManageBillIn";
            this.lstManageBillIn.Size = new System.Drawing.Size(572, 150);
            this.lstManageBillIn.TabIndex = 45;
            // 
            // txtHourIn
            // 
            this.txtHourIn.Location = new System.Drawing.Point(484, 106);
            this.txtHourIn.Name = "txtHourIn";
            this.txtHourIn.Size = new System.Drawing.Size(66, 20);
            this.txtHourIn.TabIndex = 44;
            this.txtHourIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourIn
            // 
            this.lblHourIn.AutoSize = true;
            this.lblHourIn.Location = new System.Drawing.Point(431, 113);
            this.lblHourIn.Name = "lblHourIn";
            this.lblHourIn.Size = new System.Drawing.Size(47, 13);
            this.lblHourIn.TabIndex = 43;
            this.lblHourIn.Text = "Giờ bán:";
            // 
            // txtDayIn
            // 
            this.txtDayIn.Location = new System.Drawing.Point(330, 106);
            this.txtDayIn.Name = "txtDayIn";
            this.txtDayIn.Size = new System.Drawing.Size(95, 20);
            this.txtDayIn.TabIndex = 42;
            this.txtDayIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodeIn
            // 
            this.txtCodeIn.BackColor = System.Drawing.Color.White;
            this.txtCodeIn.Location = new System.Drawing.Point(87, 106);
            this.txtCodeIn.Name = "txtCodeIn";
            this.txtCodeIn.ReadOnly = true;
            this.txtCodeIn.Size = new System.Drawing.Size(158, 20);
            this.txtCodeIn.TabIndex = 41;
            this.txtCodeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(87, 68);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.ReadOnly = true;
            this.txtNameIn.Size = new System.Drawing.Size(158, 20);
            this.txtNameIn.TabIndex = 40;
            this.txtNameIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDayIn
            // 
            this.lblDayIn.AutoSize = true;
            this.lblDayIn.Location = new System.Drawing.Point(268, 113);
            this.lblDayIn.Name = "lblDayIn";
            this.lblDayIn.Size = new System.Drawing.Size(56, 13);
            this.lblDayIn.TabIndex = 39;
            this.lblDayIn.Text = "Ngày bán:";
            // 
            // lblCodeIn
            // 
            this.lblCodeIn.AutoSize = true;
            this.lblCodeIn.Location = new System.Drawing.Point(25, 113);
            this.lblCodeIn.Name = "lblCodeIn";
            this.lblCodeIn.Size = new System.Drawing.Size(52, 13);
            this.lblCodeIn.TabIndex = 38;
            this.lblCodeIn.Text = "Số phiếu:";
            // 
            // lblNameIn
            // 
            this.lblNameIn.AutoSize = true;
            this.lblNameIn.Location = new System.Drawing.Point(25, 75);
            this.lblNameIn.Name = "lblNameIn";
            this.lblNameIn.Size = new System.Drawing.Size(56, 13);
            this.lblNameIn.TabIndex = 37;
            this.lblNameIn.Text = "Thu ngân:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 31);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Thêm hóa đơn";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(568, 113);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 13);
            this.lblPos.TabIndex = 55;
            this.lblPos.Text = "POS:";
            // 
            // txtPOS
            // 
            this.txtPOS.Location = new System.Drawing.Point(606, 106);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.Size = new System.Drawing.Size(48, 20);
            this.txtPOS.TabIndex = 56;
            this.txtPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GUI_InsertBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 458);
            this.Controls.Add(this.txtPOS);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnSaveIn);
            this.Controls.Add(this.btnCancelIn);
            this.Controls.Add(this.txtExcessCashIn);
            this.Controls.Add(this.lblExcessCashIn);
            this.Controls.Add(this.txtGuestMoneyIn);
            this.Controls.Add(this.txtTotalIn);
            this.Controls.Add(this.lblGuestMoneyIn);
            this.Controls.Add(this.lblTotalIn);
            this.Controls.Add(this.lblUpIn);
            this.Controls.Add(this.lstManageBillIn);
            this.Controls.Add(this.txtHourIn);
            this.Controls.Add(this.lblHourIn);
            this.Controls.Add(this.txtDayIn);
            this.Controls.Add(this.txtCodeIn);
            this.Controls.Add(this.txtNameIn);
            this.Controls.Add(this.lblDayIn);
            this.Controls.Add(this.lblCodeIn);
            this.Controls.Add(this.lblNameIn);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_InsertBill";
            this.Text = "GUI_InsertBill";
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveIn;
        private System.Windows.Forms.Button btnCancelIn;
        private System.Windows.Forms.TextBox txtExcessCashIn;
        private System.Windows.Forms.Label lblExcessCashIn;
        private System.Windows.Forms.TextBox txtGuestMoneyIn;
        private System.Windows.Forms.TextBox txtTotalIn;
        private System.Windows.Forms.Label lblGuestMoneyIn;
        private System.Windows.Forms.Label lblTotalIn;
        private System.Windows.Forms.LinkLabel lblUpIn;
        private System.Windows.Forms.DataGridView lstManageBillIn;
        private System.Windows.Forms.TextBox txtHourIn;
        private System.Windows.Forms.Label lblHourIn;
        private System.Windows.Forms.TextBox txtDayIn;
        private System.Windows.Forms.TextBox txtCodeIn;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.Label lblDayIn;
        private System.Windows.Forms.Label lblCodeIn;
        private System.Windows.Forms.Label lblNameIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.TextBox txtPOS;
    }
}