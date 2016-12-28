namespace WindowsFormsApplication
{
    partial class GUI_UpdateBranchImportBallot
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
            this.lstBallotDetail = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeadquarterBallotNum = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstBallotDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBallotDetail
            // 
            this.lstBallotDetail.AllowUserToDeleteRows = false;
            this.lstBallotDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBallotDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Number,
            this.Status});
            this.lstBallotDetail.Location = new System.Drawing.Point(23, 150);
            this.lstBallotDetail.Margin = new System.Windows.Forms.Padding(2);
            this.lstBallotDetail.Name = "lstBallotDetail";
            this.lstBallotDetail.RowTemplate.Height = 24;
            this.lstBallotDetail.Size = new System.Drawing.Size(579, 188);
            this.lstBallotDetail.TabIndex = 66;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(112, 113);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(159, 20);
            this.txtDate.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Ngày nhập:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 353);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.clickSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(538, 353);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.clickCancel);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(444, 113);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(159, 20);
            this.txtBranch.TabIndex = 59;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(444, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Chi nhánh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Người nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Số phiếu NHTS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cập nhật phiếu nhập hàng chi nhánh";
            // 
            // txtHeadquarterBallotNum
            // 
            this.txtHeadquarterBallotNum.Location = new System.Drawing.Point(112, 79);
            this.txtHeadquarterBallotNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeadquarterBallotNum.Name = "txtHeadquarterBallotNum";
            this.txtHeadquarterBallotNum.ReadOnly = true;
            this.txtHeadquarterBallotNum.Size = new System.Drawing.Size(159, 20);
            this.txtHeadquarterBallotNum.TabIndex = 67;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product.HeaderText = "Sản phẩm";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 80;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "SL";
            this.Number.Name = "Number";
            this.Number.Width = 45;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Tình trạng";
            this.Status.Items.AddRange(new object[] {
            "Đủ",
            "Không đủ",
            "Hết hạn",
            "Hư hỏng"});
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 80;
            // 
            // GUI_UpdateBranchImportBallot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 405);
            this.Controls.Add(this.txtHeadquarterBallotNum);
            this.Controls.Add(this.lstBallotDetail);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_UpdateBranchImportBallot";
            this.Text = "GUI_UpdateBranchImportBallot";
            this.Load += new System.EventHandler(this.showUpdateBranchImportBallotForm);
            ((System.ComponentModel.ISupportInitialize)(this.lstBallotDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstBallotDetail;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeadquarterBallotNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;

    }
}