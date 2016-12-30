﻿namespace WindowsFormsApplication.Statistics_and_Report
{
    partial class GUI_InsertStatistic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.rbMilestoneTime = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDayCreate = new System.Windows.Forms.TextBox();
            this.rbRangeTime = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDayStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDayEnd = new System.Windows.Forms.DateTimePicker();
            this.lstProduct = new System.Windows.Forms.DataGridView();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(78, 50);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(160, 20);
            this.txtBillCode.TabIndex = 2;
            // 
            // rbMilestoneTime
            // 
            this.rbMilestoneTime.AutoSize = true;
            this.rbMilestoneTime.Checked = true;
            this.rbMilestoneTime.Location = new System.Drawing.Point(12, 85);
            this.rbMilestoneTime.Name = "rbMilestoneTime";
            this.rbMilestoneTime.Size = new System.Drawing.Size(89, 17);
            this.rbMilestoneTime.TabIndex = 3;
            this.rbMilestoneTime.TabStop = true;
            this.rbMilestoneTime.Text = "Mốc thời gian";
            this.rbMilestoneTime.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(22, 110);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(50, 17);
            this.rbDay.TabIndex = 4;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Ngày";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(78, 110);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(78, 136);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(160, 21);
            this.cboMonth.TabIndex = 8;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(78, 163);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(160, 21);
            this.cboYear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày lập:";
            // 
            // txtDayCreate
            // 
            this.txtDayCreate.Location = new System.Drawing.Point(318, 50);
            this.txtDayCreate.Name = "txtDayCreate";
            this.txtDayCreate.ReadOnly = true;
            this.txtDayCreate.Size = new System.Drawing.Size(160, 20);
            this.txtDayCreate.TabIndex = 11;
            // 
            // rbRangeTime
            // 
            this.rbRangeTime.AutoSize = true;
            this.rbRangeTime.Location = new System.Drawing.Point(279, 85);
            this.rbRangeTime.Name = "rbRangeTime";
            this.rbRangeTime.Size = new System.Drawing.Size(105, 17);
            this.rbRangeTime.TabIndex = 12;
            this.rbRangeTime.TabStop = true;
            this.rbRangeTime.Text = "Khoảng thời gian";
            this.rbRangeTime.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ:";
            // 
            // dtpDayStart
            // 
            this.dtpDayStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDayStart.Location = new System.Drawing.Point(318, 110);
            this.dtpDayStart.Name = "dtpDayStart";
            this.dtpDayStart.Size = new System.Drawing.Size(160, 20);
            this.dtpDayStart.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đến:";
            // 
            // dtpDayEnd
            // 
            this.dtpDayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDayEnd.Location = new System.Drawing.Point(318, 136);
            this.dtpDayEnd.Name = "dtpDayEnd";
            this.dtpDayEnd.Size = new System.Drawing.Size(160, 20);
            this.dtpDayEnd.TabIndex = 16;
            // 
            // lstProduct
            // 
            this.lstProduct.AllowUserToAddRows = false;
            this.lstProduct.AllowUserToDeleteRows = false;
            this.lstProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstProduct.Location = new System.Drawing.Point(12, 198);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.ReadOnly = true;
            this.lstProduct.Size = new System.Drawing.Size(466, 188);
            this.lstProduct.TabIndex = 17;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(344, 398);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(64, 28);
            this.btnStatistic.TabIndex = 18;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(414, 398);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(64, 28);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Năm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(93, 398);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 26);
            this.txtTotal.TabIndex = 23;
            // 
            // GUI_InsertStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 437);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.dtpDayEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDayStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbRangeTime);
            this.Controls.Add(this.txtDayCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rbDay);
            this.Controls.Add(this.rbMilestoneTime);
            this.Controls.Add(this.txtBillCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_InsertStatistic";
            this.Text = " THỐNG KÊ DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.lstProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.RadioButton rbMilestoneTime;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDayCreate;
        private System.Windows.Forms.RadioButton rbRangeTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDayStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDayEnd;
        private System.Windows.Forms.DataGridView lstProduct;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
    }
}