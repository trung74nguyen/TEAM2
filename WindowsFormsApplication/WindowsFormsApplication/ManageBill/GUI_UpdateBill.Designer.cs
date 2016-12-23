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
            this.lblVND3 = new System.Windows.Forms.Label();
            this.lblVND2 = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.lblBallotNum = new System.Windows.Forms.Label();
            this.txtBallotNum = new System.Windows.Forms.TextBox();
            this.txtExcessCashUp = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txtPOS = new System.Windows.Forms.TextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnSaveUp = new System.Windows.Forms.Button();
            this.btnCancelUp = new System.Windows.Forms.Button();
            this.lblExcessCashIn = new System.Windows.Forms.Label();
            this.txtGuestMoneyUp = new System.Windows.Forms.TextBox();
            this.txt_TotalNum = new System.Windows.Forms.TextBox();
            this.lblGuestMoneyIn = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lstManageBillUp = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHourUp = new System.Windows.Forms.TextBox();
            this.lblHourIn = new System.Windows.Forms.Label();
            this.txtDayUp = new System.Windows.Forms.TextBox();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.lblDayIn = new System.Windows.Forms.Label();
            this.lblNameIn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVND3
            // 
            this.lblVND3.AutoSize = true;
            this.lblVND3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND3.Location = new System.Drawing.Point(609, 354);
            this.lblVND3.Name = "lblVND3";
            this.lblVND3.Size = new System.Drawing.Size(34, 15);
            this.lblVND3.TabIndex = 94;
            this.lblVND3.Text = "VNĐ";
            // 
            // lblVND2
            // 
            this.lblVND2.AutoSize = true;
            this.lblVND2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND2.Location = new System.Drawing.Point(609, 316);
            this.lblVND2.Name = "lblVND2";
            this.lblVND2.Size = new System.Drawing.Size(34, 15);
            this.lblVND2.TabIndex = 93;
            this.lblVND2.Text = "VNĐ";
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.Location = new System.Drawing.Point(254, 350);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(34, 15);
            this.lblVND.TabIndex = 92;
            this.lblVND.Text = "VNĐ";
            // 
            // lblBallotNum
            // 
            this.lblBallotNum.AutoSize = true;
            this.lblBallotNum.Location = new System.Drawing.Point(27, 117);
            this.lblBallotNum.Name = "lblBallotNum";
            this.lblBallotNum.Size = new System.Drawing.Size(68, 13);
            this.lblBallotNum.TabIndex = 90;
            this.lblBallotNum.Text = "Mã hóa đơn:";
            // 
            // txtBallotNum
            // 
            this.txtBallotNum.Location = new System.Drawing.Point(119, 110);
            this.txtBallotNum.Name = "txtBallotNum";
            this.txtBallotNum.ReadOnly = true;
            this.txtBallotNum.Size = new System.Drawing.Size(129, 20);
            this.txtBallotNum.TabIndex = 89;
            this.txtBallotNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExcessCashUp
            // 
            this.txtExcessCashUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcessCashUp.Location = new System.Drawing.Point(474, 351);
            this.txtExcessCashUp.Name = "txtExcessCashUp";
            this.txtExcessCashUp.ReadOnly = true;
            this.txtExcessCashUp.Size = new System.Drawing.Size(129, 22);
            this.txtExcessCashUp.TabIndex = 88;
            this.txtExcessCashUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(119, 347);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(129, 22);
            this.txt_Total.TabIndex = 87;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(28, 354);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(55, 13);
            this.lbl_Total.TabIndex = 86;
            this.lbl_Total.Text = "Tổng tiền:";
            // 
            // txtPOS
            // 
            this.txtPOS.Location = new System.Drawing.Point(525, 107);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.ReadOnly = true;
            this.txtPOS.Size = new System.Drawing.Size(78, 20);
            this.txtPOS.TabIndex = 84;
            this.txtPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(487, 110);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 13);
            this.lblPos.TabIndex = 83;
            this.lblPos.Text = "POS:";
            // 
            // btnSaveUp
            // 
            this.btnSaveUp.Location = new System.Drawing.Point(505, 410);
            this.btnSaveUp.Name = "btnSaveUp";
            this.btnSaveUp.Size = new System.Drawing.Size(75, 30);
            this.btnSaveUp.TabIndex = 82;
            this.btnSaveUp.Text = "Lưu";
            this.btnSaveUp.UseVisualStyleBackColor = true;
            this.btnSaveUp.Click += new System.EventHandler(this.clickUpdate);
            // 
            // btnCancelUp
            // 
            this.btnCancelUp.Location = new System.Drawing.Point(586, 410);
            this.btnCancelUp.Name = "btnCancelUp";
            this.btnCancelUp.Size = new System.Drawing.Size(75, 30);
            this.btnCancelUp.TabIndex = 81;
            this.btnCancelUp.Text = "Hủy";
            this.btnCancelUp.UseVisualStyleBackColor = true;
            this.btnCancelUp.Click += new System.EventHandler(this.btnCancelUp_Click);
            // 
            // lblExcessCashIn
            // 
            this.lblExcessCashIn.AutoSize = true;
            this.lblExcessCashIn.Location = new System.Drawing.Point(382, 358);
            this.lblExcessCashIn.Name = "lblExcessCashIn";
            this.lblExcessCashIn.Size = new System.Drawing.Size(46, 13);
            this.lblExcessCashIn.TabIndex = 80;
            this.lblExcessCashIn.Text = "Tiền dư:";
            // 
            // txtGuestMoneyUp
            // 
            this.txtGuestMoneyUp.BackColor = System.Drawing.Color.White;
            this.txtGuestMoneyUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestMoneyUp.Location = new System.Drawing.Point(474, 313);
            this.txtGuestMoneyUp.Name = "txtGuestMoneyUp";
            this.txtGuestMoneyUp.Size = new System.Drawing.Size(129, 22);
            this.txtGuestMoneyUp.TabIndex = 79;
            this.txtGuestMoneyUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuestMoneyUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestMoneyUp_KeyPress);
            // 
            // txt_TotalNum
            // 
            this.txt_TotalNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalNum.Location = new System.Drawing.Point(119, 313);
            this.txt_TotalNum.Name = "txt_TotalNum";
            this.txt_TotalNum.ReadOnly = true;
            this.txt_TotalNum.Size = new System.Drawing.Size(129, 22);
            this.txt_TotalNum.TabIndex = 78;
            this.txt_TotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuestMoneyIn
            // 
            this.lblGuestMoneyIn.AutoSize = true;
            this.lblGuestMoneyIn.Location = new System.Drawing.Point(382, 320);
            this.lblGuestMoneyIn.Name = "lblGuestMoneyIn";
            this.lblGuestMoneyIn.Size = new System.Drawing.Size(86, 13);
            this.lblGuestMoneyIn.TabIndex = 77;
            this.lblGuestMoneyIn.Text = "Tiền khách đưa:";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(29, 320);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(78, 13);
            this.lblTotalNum.TabIndex = 76;
            this.lblTotalNum.Text = "Tổng số lượng:";
            // 
            // lstManageBillUp
            // 
            this.lstManageBillUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.Number,
            this.UnitPrice,
            this.Subtotal});
            this.lstManageBillUp.Location = new System.Drawing.Point(31, 143);
            this.lstManageBillUp.Name = "lstManageBillUp";
            this.lstManageBillUp.Size = new System.Drawing.Size(572, 150);
            this.lstManageBillUp.TabIndex = 75;
            this.lstManageBillUp.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstManageBillUp_CellEnter);
            //this.lstManageBillUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstManageBillUp_KeyPress);
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Mã sản phẩm";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng";
            this.Number.Name = "Number";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Thành tiền";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // txtHourUp
            // 
            this.txtHourUp.Location = new System.Drawing.Point(525, 72);
            this.txtHourUp.Name = "txtHourUp";
            this.txtHourUp.ReadOnly = true;
            this.txtHourUp.Size = new System.Drawing.Size(78, 20);
            this.txtHourUp.TabIndex = 74;
            this.txtHourUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourIn
            // 
            this.lblHourIn.AutoSize = true;
            this.lblHourIn.Location = new System.Drawing.Point(471, 75);
            this.lblHourIn.Name = "lblHourIn";
            this.lblHourIn.Size = new System.Drawing.Size(47, 13);
            this.lblHourIn.TabIndex = 73;
            this.lblHourIn.Text = "Giờ bán:";
            // 
            // txtDayUp
            // 
            this.txtDayUp.Location = new System.Drawing.Point(350, 72);
            this.txtDayUp.Name = "txtDayUp";
            this.txtDayUp.ReadOnly = true;
            this.txtDayUp.Size = new System.Drawing.Size(78, 20);
            this.txtDayUp.TabIndex = 72;
            this.txtDayUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameUp
            // 
            this.txtNameUp.Location = new System.Drawing.Point(90, 72);
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.ReadOnly = true;
            this.txtNameUp.Size = new System.Drawing.Size(158, 20);
            this.txtNameUp.TabIndex = 71;
            this.txtNameUp.Text = "Dương Thành Công Lý";
            this.txtNameUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDayIn
            // 
            this.lblDayIn.AutoSize = true;
            this.lblDayIn.Location = new System.Drawing.Point(288, 79);
            this.lblDayIn.Name = "lblDayIn";
            this.lblDayIn.Size = new System.Drawing.Size(56, 13);
            this.lblDayIn.TabIndex = 70;
            this.lblDayIn.Text = "Ngày bán:";
            // 
            // lblNameIn
            // 
            this.lblNameIn.AutoSize = true;
            this.lblNameIn.Location = new System.Drawing.Point(27, 79);
            this.lblNameIn.Name = "lblNameIn";
            this.lblNameIn.Size = new System.Drawing.Size(56, 13);
            this.lblNameIn.TabIndex = 69;
            this.lblNameIn.Text = "Thu ngân:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(268, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 31);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "Cập nhật hóa đơn";
            // 
            // GUI_UpdateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 458);
            this.Controls.Add(this.lblVND3);
            this.Controls.Add(this.lblVND2);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lblBallotNum);
            this.Controls.Add(this.txtBallotNum);
            this.Controls.Add(this.txtExcessCashUp);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txtPOS);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnSaveUp);
            this.Controls.Add(this.btnCancelUp);
            this.Controls.Add(this.lblExcessCashIn);
            this.Controls.Add(this.txtGuestMoneyUp);
            this.Controls.Add(this.txt_TotalNum);
            this.Controls.Add(this.lblGuestMoneyIn);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lstManageBillUp);
            this.Controls.Add(this.txtHourUp);
            this.Controls.Add(this.lblHourIn);
            this.Controls.Add(this.txtDayUp);
            this.Controls.Add(this.txtNameUp);
            this.Controls.Add(this.lblDayIn);
            this.Controls.Add(this.lblNameIn);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI_UpdateBill";
            this.Text = "GUI_UpdateBill";
            this.Load += new System.EventHandler(this.loadDataBillToForm);
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVND3;
        private System.Windows.Forms.Label lblVND2;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Label lblBallotNum;
        private System.Windows.Forms.TextBox txtBallotNum;
        private System.Windows.Forms.TextBox txtExcessCashUp;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txtPOS;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnSaveUp;
        private System.Windows.Forms.Button btnCancelUp;
        private System.Windows.Forms.Label lblExcessCashIn;
        private System.Windows.Forms.TextBox txtGuestMoneyUp;
        private System.Windows.Forms.TextBox txt_TotalNum;
        private System.Windows.Forms.Label lblGuestMoneyIn;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.DataGridView lstManageBillUp;
        private System.Windows.Forms.TextBox txtHourUp;
        private System.Windows.Forms.Label lblHourIn;
        private System.Windows.Forms.TextBox txtDayUp;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.Label lblDayIn;
        private System.Windows.Forms.Label lblNameIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;

    }
}