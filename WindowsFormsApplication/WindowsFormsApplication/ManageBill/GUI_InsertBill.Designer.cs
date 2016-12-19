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
            this.lblExcessCashIn = new System.Windows.Forms.Label();
            this.txtGuestMoneyIn = new System.Windows.Forms.TextBox();
            this.txt_TotalNum = new System.Windows.Forms.TextBox();
            this.lblGuestMoneyIn = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblUpIn = new System.Windows.Forms.LinkLabel();
            this.lstManageBillIn = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHourIn = new System.Windows.Forms.TextBox();
            this.lblHourIn = new System.Windows.Forms.Label();
            this.txtDayIn = new System.Windows.Forms.TextBox();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.lblDayIn = new System.Windows.Forms.Label();
            this.lblNameIn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtPOS = new System.Windows.Forms.TextBox();
            this.nud_Number = new System.Windows.Forms.NumericUpDown();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txtExcessCashIn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Number)).BeginInit();
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
            this.btnSaveIn.Click += new System.EventHandler(this.clickSave);
            // 
            // btnCancelIn
            // 
            this.btnCancelIn.Location = new System.Drawing.Point(583, 416);
            this.btnCancelIn.Name = "btnCancelIn";
            this.btnCancelIn.Size = new System.Drawing.Size(75, 30);
            this.btnCancelIn.TabIndex = 53;
            this.btnCancelIn.Text = "Hủy";
            this.btnCancelIn.UseVisualStyleBackColor = true;
            this.btnCancelIn.Click += new System.EventHandler(this.clickCancel);
            // 
            // lblExcessCashIn
            // 
            this.lblExcessCashIn.AutoSize = true;
            this.lblExcessCashIn.Location = new System.Drawing.Point(379, 364);
            this.lblExcessCashIn.Name = "lblExcessCashIn";
            this.lblExcessCashIn.Size = new System.Drawing.Size(46, 13);
            this.lblExcessCashIn.TabIndex = 51;
            this.lblExcessCashIn.Text = "Tiền dư:";
            // 
            // txtGuestMoneyIn
            // 
            this.txtGuestMoneyIn.BackColor = System.Drawing.Color.White;
            this.txtGuestMoneyIn.Location = new System.Drawing.Point(471, 319);
            this.txtGuestMoneyIn.Name = "txtGuestMoneyIn";
            this.txtGuestMoneyIn.Size = new System.Drawing.Size(129, 20);
            this.txtGuestMoneyIn.TabIndex = 50;
            this.txtGuestMoneyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalNum
            // 
            this.txt_TotalNum.Location = new System.Drawing.Point(116, 319);
            this.txt_TotalNum.Name = "txt_TotalNum";
            this.txt_TotalNum.ReadOnly = true;
            this.txt_TotalNum.Size = new System.Drawing.Size(129, 20);
            this.txt_TotalNum.TabIndex = 49;
            this.txt_TotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuestMoneyIn
            // 
            this.lblGuestMoneyIn.AutoSize = true;
            this.lblGuestMoneyIn.Location = new System.Drawing.Point(379, 326);
            this.lblGuestMoneyIn.Name = "lblGuestMoneyIn";
            this.lblGuestMoneyIn.Size = new System.Drawing.Size(86, 13);
            this.lblGuestMoneyIn.TabIndex = 48;
            this.lblGuestMoneyIn.Text = "Tiền khách đưa:";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(26, 326);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(78, 13);
            this.lblTotalNum.TabIndex = 47;
            this.lblTotalNum.Text = "Tổng số lượng:";
            // 
            // lblUpIn
            // 
            this.lblUpIn.AutoSize = true;
            this.lblUpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpIn.Location = new System.Drawing.Point(626, 149);
            this.lblUpIn.Name = "lblUpIn";
            this.lblUpIn.Size = new System.Drawing.Size(32, 16);
            this.lblUpIn.TabIndex = 46;
            this.lblUpIn.TabStop = true;
            this.lblUpIn.Text = "Sửa";
            // 
            // lstManageBillIn
            // 
            this.lstManageBillIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.UnitPrice,
            this.Number,
            this.Total});
            this.lstManageBillIn.Location = new System.Drawing.Point(28, 149);
            this.lstManageBillIn.Name = "lstManageBillIn";
            this.lstManageBillIn.Size = new System.Drawing.Size(572, 150);
            this.lstManageBillIn.TabIndex = 45;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Mã sản phẩm";
            this.ProductCode.Name = "ProductCode";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng ";
            this.Number.Name = "Number";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            // 
            // txtHourIn
            // 
            this.txtHourIn.Location = new System.Drawing.Point(484, 99);
            this.txtHourIn.Name = "txtHourIn";
            this.txtHourIn.ReadOnly = true;
            this.txtHourIn.Size = new System.Drawing.Size(66, 20);
            this.txtHourIn.TabIndex = 44;
            this.txtHourIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourIn
            // 
            this.lblHourIn.AutoSize = true;
            this.lblHourIn.Location = new System.Drawing.Point(431, 106);
            this.lblHourIn.Name = "lblHourIn";
            this.lblHourIn.Size = new System.Drawing.Size(47, 13);
            this.lblHourIn.TabIndex = 43;
            this.lblHourIn.Text = "Giờ bán:";
            // 
            // txtDayIn
            // 
            this.txtDayIn.Location = new System.Drawing.Point(330, 99);
            this.txtDayIn.Name = "txtDayIn";
            this.txtDayIn.ReadOnly = true;
            this.txtDayIn.Size = new System.Drawing.Size(95, 20);
            this.txtDayIn.TabIndex = 42;
            this.txtDayIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(87, 99);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.ReadOnly = true;
            this.txtNameIn.Size = new System.Drawing.Size(158, 20);
            this.txtNameIn.TabIndex = 40;
            this.txtNameIn.Text = "Dương Thành Công Lý";
            this.txtNameIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDayIn
            // 
            this.lblDayIn.AutoSize = true;
            this.lblDayIn.Location = new System.Drawing.Point(268, 106);
            this.lblDayIn.Name = "lblDayIn";
            this.lblDayIn.Size = new System.Drawing.Size(56, 13);
            this.lblDayIn.TabIndex = 39;
            this.lblDayIn.Text = "Ngày bán:";
            // 
            // lblNameIn
            // 
            this.lblNameIn.AutoSize = true;
            this.lblNameIn.Location = new System.Drawing.Point(25, 106);
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
            this.lblPos.Location = new System.Drawing.Point(568, 106);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 13);
            this.lblPos.TabIndex = 55;
            this.lblPos.Text = "POS:";
            // 
            // txtPOS
            // 
            this.txtPOS.Location = new System.Drawing.Point(610, 99);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.Size = new System.Drawing.Size(48, 20);
            this.txtPOS.TabIndex = 56;
            this.txtPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_Number
            // 
            this.nud_Number.Location = new System.Drawing.Point(610, 168);
            this.nud_Number.Name = "nud_Number";
            this.nud_Number.Size = new System.Drawing.Size(48, 20);
            this.nud_Number.TabIndex = 57;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(116, 353);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(129, 20);
            this.txt_Total.TabIndex = 59;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(25, 360);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(55, 13);
            this.lbl_Total.TabIndex = 58;
            this.lbl_Total.Text = "Tổng tiền:";
            // 
            // txtExcessCashIn
            // 
            this.txtExcessCashIn.Location = new System.Drawing.Point(471, 357);
            this.txtExcessCashIn.Name = "txtExcessCashIn";
            this.txtExcessCashIn.ReadOnly = true;
            this.txtExcessCashIn.Size = new System.Drawing.Size(129, 20);
            this.txtExcessCashIn.TabIndex = 60;
            this.txtExcessCashIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GUI_InsertBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 458);
            this.Controls.Add(this.txtExcessCashIn);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.nud_Number);
            this.Controls.Add(this.txtPOS);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnSaveIn);
            this.Controls.Add(this.btnCancelIn);
            this.Controls.Add(this.lblExcessCashIn);
            this.Controls.Add(this.txtGuestMoneyIn);
            this.Controls.Add(this.txt_TotalNum);
            this.Controls.Add(this.lblGuestMoneyIn);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblUpIn);
            this.Controls.Add(this.lstManageBillIn);
            this.Controls.Add(this.txtHourIn);
            this.Controls.Add(this.lblHourIn);
            this.Controls.Add(this.txtDayIn);
            this.Controls.Add(this.txtNameIn);
            this.Controls.Add(this.lblDayIn);
            this.Controls.Add(this.lblNameIn);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_InsertBill";
            this.Text = "GUI_InsertBill";
            this.Load += new System.EventHandler(this.GUI_InsertBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveIn;
        private System.Windows.Forms.Button btnCancelIn;
        private System.Windows.Forms.Label lblExcessCashIn;
        private System.Windows.Forms.TextBox txtGuestMoneyIn;
        private System.Windows.Forms.TextBox txt_TotalNum;
        private System.Windows.Forms.Label lblGuestMoneyIn;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.LinkLabel lblUpIn;
        private System.Windows.Forms.DataGridView lstManageBillIn;
        private System.Windows.Forms.TextBox txtHourIn;
        private System.Windows.Forms.Label lblHourIn;
        private System.Windows.Forms.TextBox txtDayIn;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.Label lblDayIn;
        private System.Windows.Forms.Label lblNameIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.TextBox txtPOS;
        private System.Windows.Forms.NumericUpDown nud_Number;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txtExcessCashIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}