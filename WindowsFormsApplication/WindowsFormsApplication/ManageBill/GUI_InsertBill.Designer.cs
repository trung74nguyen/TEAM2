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
            this.lstManageBillIn = new System.Windows.Forms.DataGridView();
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.lblVND2 = new System.Windows.Forms.Label();
            this.lblVND3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstManageBillIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveIn
            // 
            this.btnSaveIn.Location = new System.Drawing.Point(354, 347);
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.Size = new System.Drawing.Size(64, 28);
            this.btnSaveIn.TabIndex = 54;
            this.btnSaveIn.Text = "Lưu";
            this.btnSaveIn.UseVisualStyleBackColor = true;
            this.btnSaveIn.Click += new System.EventHandler(this.clickSave);
            // 
            // btnCancelIn
            // 
            this.btnCancelIn.Location = new System.Drawing.Point(424, 347);
            this.btnCancelIn.Name = "btnCancelIn";
            this.btnCancelIn.Size = new System.Drawing.Size(64, 28);
            this.btnCancelIn.TabIndex = 53;
            this.btnCancelIn.Text = "Hủy";
            this.btnCancelIn.UseVisualStyleBackColor = true;
            this.btnCancelIn.Click += new System.EventHandler(this.clickCancel);
            // 
            // lblExcessCashIn
            // 
            this.lblExcessCashIn.AutoSize = true;
            this.lblExcessCashIn.Location = new System.Drawing.Point(8, 370);
            this.lblExcessCashIn.Name = "lblExcessCashIn";
            this.lblExcessCashIn.Size = new System.Drawing.Size(92, 13);
            this.lblExcessCashIn.TabIndex = 51;
            this.lblExcessCashIn.Text = "Tiền trả lại khách:";
            // 
            // txtGuestMoneyIn
            // 
            this.txtGuestMoneyIn.BackColor = System.Drawing.Color.White;
            this.txtGuestMoneyIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestMoneyIn.Location = new System.Drawing.Point(106, 338);
            this.txtGuestMoneyIn.Name = "txtGuestMoneyIn";
            this.txtGuestMoneyIn.Size = new System.Drawing.Size(140, 22);
            this.txtGuestMoneyIn.TabIndex = 50;
            this.txtGuestMoneyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuestMoneyIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestMoneyIn_KeyPress);
            // 
            // txt_TotalNum
            // 
            this.txt_TotalNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalNum.Location = new System.Drawing.Point(408, 310);
            this.txt_TotalNum.Name = "txt_TotalNum";
            this.txt_TotalNum.ReadOnly = true;
            this.txt_TotalNum.Size = new System.Drawing.Size(80, 22);
            this.txt_TotalNum.TabIndex = 49;
            this.txt_TotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuestMoneyIn
            // 
            this.lblGuestMoneyIn.AutoSize = true;
            this.lblGuestMoneyIn.Location = new System.Drawing.Point(14, 342);
            this.lblGuestMoneyIn.Name = "lblGuestMoneyIn";
            this.lblGuestMoneyIn.Size = new System.Drawing.Size(86, 13);
            this.lblGuestMoneyIn.TabIndex = 48;
            this.lblGuestMoneyIn.Text = "Tiền khách đưa:";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(324, 314);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(78, 13);
            this.lblTotalNum.TabIndex = 47;
            this.lblTotalNum.Text = "Tổng số lượng:";
            // 
            // lstManageBillIn
            // 
            this.lstManageBillIn.AllowUserToAddRows = false;
            this.lstManageBillIn.AllowUserToDeleteRows = false;
            this.lstManageBillIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstManageBillIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstManageBillIn.Location = new System.Drawing.Point(12, 108);
            this.lstManageBillIn.Name = "lstManageBillIn";
            this.lstManageBillIn.ReadOnly = true;
            this.lstManageBillIn.Size = new System.Drawing.Size(478, 188);
            this.lstManageBillIn.TabIndex = 45;
            // 
            // txtHourIn
            // 
            this.txtHourIn.Location = new System.Drawing.Point(313, 77);
            this.txtHourIn.Name = "txtHourIn";
            this.txtHourIn.ReadOnly = true;
            this.txtHourIn.Size = new System.Drawing.Size(80, 20);
            this.txtHourIn.TabIndex = 44;
            this.txtHourIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHourIn
            // 
            this.lblHourIn.AutoSize = true;
            this.lblHourIn.Location = new System.Drawing.Point(260, 80);
            this.lblHourIn.Name = "lblHourIn";
            this.lblHourIn.Size = new System.Drawing.Size(47, 13);
            this.lblHourIn.TabIndex = 43;
            this.lblHourIn.Text = "Giờ bán:";
            // 
            // txtDayIn
            // 
            this.txtDayIn.Location = new System.Drawing.Point(313, 47);
            this.txtDayIn.Name = "txtDayIn";
            this.txtDayIn.ReadOnly = true;
            this.txtDayIn.Size = new System.Drawing.Size(80, 20);
            this.txtDayIn.TabIndex = 42;
            this.txtDayIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(92, 47);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.ReadOnly = true;
            this.txtNameIn.Size = new System.Drawing.Size(140, 20);
            this.txtNameIn.TabIndex = 40;
            this.txtNameIn.Text = "Dương Thành Công Lý";
            // 
            // lblDayIn
            // 
            this.lblDayIn.AutoSize = true;
            this.lblDayIn.Location = new System.Drawing.Point(251, 50);
            this.lblDayIn.Name = "lblDayIn";
            this.lblDayIn.Size = new System.Drawing.Size(56, 13);
            this.lblDayIn.TabIndex = 39;
            this.lblDayIn.Text = "Ngày bán:";
            // 
            // lblNameIn
            // 
            this.lblNameIn.AutoSize = true;
            this.lblNameIn.Location = new System.Drawing.Point(30, 50);
            this.lblNameIn.Name = "lblNameIn";
            this.lblNameIn.Size = new System.Drawing.Size(56, 13);
            this.lblNameIn.TabIndex = 37;
            this.lblNameIn.Text = "Thu ngân:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 26);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "THÊM HÓA ĐƠN";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(412, 50);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 13);
            this.lblPos.TabIndex = 55;
            this.lblPos.Text = "POS:";
            // 
            // txtPOS
            // 
            this.txtPOS.Location = new System.Drawing.Point(450, 47);
            this.txtPOS.Name = "txtPOS";
            this.txtPOS.Size = new System.Drawing.Size(40, 20);
            this.txtPOS.TabIndex = 56;
            this.txtPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_Number
            // 
            this.nud_Number.Location = new System.Drawing.Point(450, 77);
            this.nud_Number.Name = "nud_Number";
            this.nud_Number.Size = new System.Drawing.Size(40, 20);
            this.nud_Number.TabIndex = 57;
            this.nud_Number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Number_KeyPress);
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(106, 310);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(140, 22);
            this.txt_Total.TabIndex = 59;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(45, 314);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(55, 13);
            this.lbl_Total.TabIndex = 58;
            this.lbl_Total.Text = "Tổng tiền:";
            // 
            // txtExcessCashIn
            // 
            this.txtExcessCashIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcessCashIn.Location = new System.Drawing.Point(106, 366);
            this.txtExcessCashIn.Name = "txtExcessCashIn";
            this.txtExcessCashIn.ReadOnly = true;
            this.txtExcessCashIn.Size = new System.Drawing.Size(140, 22);
            this.txtExcessCashIn.TabIndex = 60;
            this.txtExcessCashIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(92, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 20);
            this.txtid.TabIndex = 61;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(12, 79);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(74, 13);
            this.lblProductCode.TabIndex = 63;
            this.lblProductCode.Text = "Mã sản phẩm:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(421, 79);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(23, 13);
            this.lblQuantity.TabIndex = 64;
            this.lblQuantity.Text = "SL:";
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.Location = new System.Drawing.Point(252, 313);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(34, 15);
            this.lblVND.TabIndex = 65;
            this.lblVND.Text = "VNĐ";
            // 
            // lblVND2
            // 
            this.lblVND2.AutoSize = true;
            this.lblVND2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND2.Location = new System.Drawing.Point(252, 341);
            this.lblVND2.Name = "lblVND2";
            this.lblVND2.Size = new System.Drawing.Size(34, 15);
            this.lblVND2.TabIndex = 66;
            this.lblVND2.Text = "VNĐ";
            // 
            // lblVND3
            // 
            this.lblVND3.AutoSize = true;
            this.lblVND3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND3.Location = new System.Drawing.Point(252, 369);
            this.lblVND3.Name = "lblVND3";
            this.lblVND3.Size = new System.Drawing.Size(34, 15);
            this.lblVND3.TabIndex = 67;
            this.lblVND3.Text = "VNĐ";
            // 
            // GUI_InsertBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 400);
            this.Controls.Add(this.lblVND3);
            this.Controls.Add(this.lblVND2);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtid);
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
            this.Controls.Add(this.lstManageBillIn);
            this.Controls.Add(this.txtHourIn);
            this.Controls.Add(this.lblHourIn);
            this.Controls.Add(this.txtDayIn);
            this.Controls.Add(this.txtNameIn);
            this.Controls.Add(this.lblDayIn);
            this.Controls.Add(this.lblNameIn);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_InsertBill";
            this.Text = "THÊM HÓA ĐƠN";
            this.Load += new System.EventHandler(this.loadFormInsert);
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
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Label lblVND2;
        private System.Windows.Forms.Label lblVND3;
    }
}