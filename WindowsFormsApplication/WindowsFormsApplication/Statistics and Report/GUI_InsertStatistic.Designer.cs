namespace WindowsFormsApplication.Statistics_and_Report
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
            this.rpMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbRangeTime = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDayStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDayEnd = new System.Windows.Forms.DateTimePicker();
            this.lstProduct = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "THỐNG KÊ";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(94, 67);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(182, 20);
            this.txtBillCode.TabIndex = 2;
            // 
            // rbMilestoneTime
            // 
            this.rbMilestoneTime.AutoSize = true;
            this.rbMilestoneTime.Checked = true;
            this.rbMilestoneTime.Location = new System.Drawing.Point(37, 110);
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
            this.rbDay.Location = new System.Drawing.Point(58, 146);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(50, 17);
            this.rbDay.TabIndex = 4;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Ngày";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rpMonth
            // 
            this.rpMonth.AutoSize = true;
            this.rpMonth.Location = new System.Drawing.Point(58, 180);
            this.rpMonth.Name = "rpMonth";
            this.rpMonth.Size = new System.Drawing.Size(56, 17);
            this.rpMonth.TabIndex = 5;
            this.rpMonth.TabStop = true;
            this.rpMonth.Text = "Tháng";
            this.rpMonth.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(58, 218);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(47, 17);
            this.rbYear.TabIndex = 6;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Năm";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(124, 146);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(124, 180);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(200, 21);
            this.cboMonth.TabIndex = 8;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(124, 217);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(200, 21);
            this.cboYear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày lập:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 11;
            // 
            // rbRangeTime
            // 
            this.rbRangeTime.AutoSize = true;
            this.rbRangeTime.Location = new System.Drawing.Point(453, 110);
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
            this.label4.Location = new System.Drawing.Point(486, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // dtpDayStart
            // 
            this.dtpDayStart.Location = new System.Drawing.Point(567, 158);
            this.dtpDayStart.Name = "dtpDayStart";
            this.dtpDayStart.Size = new System.Drawing.Size(200, 20);
            this.dtpDayStart.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // dtpDayEnd
            // 
            this.dtpDayEnd.Location = new System.Drawing.Point(567, 203);
            this.dtpDayEnd.Name = "dtpDayEnd";
            this.dtpDayEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpDayEnd.TabIndex = 16;
            // 
            // lstProduct
            // 
            this.lstProduct.AllowUserToAddRows = false;
            this.lstProduct.AllowUserToDeleteRows = false;
            this.lstProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstProduct.Location = new System.Drawing.Point(12, 256);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.ReadOnly = true;
            this.lstProduct.Size = new System.Drawing.Size(774, 206);
            this.lstProduct.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(630, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(711, 468);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // GUI_InsertStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 510);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.dtpDayEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDayStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbRangeTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rbYear);
            this.Controls.Add(this.rpMonth);
            this.Controls.Add(this.rbDay);
            this.Controls.Add(this.rbMilestoneTime);
            this.Controls.Add(this.txtBillCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_InsertStatistic";
            this.Text = " THỐNG KÊ";
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
        private System.Windows.Forms.RadioButton rpMonth;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbRangeTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDayStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDayEnd;
        private System.Windows.Forms.DataGridView lstProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIn;
    }
}