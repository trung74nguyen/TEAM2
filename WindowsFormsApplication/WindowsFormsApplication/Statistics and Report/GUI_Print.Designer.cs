namespace WindowsFormsApplication.Statistics_and_Report
{
    partial class GUI_Print
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
            this.crv_Product = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Product
            // 
            this.crv_Product.ActiveViewIndex = -1;
            this.crv_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Product.Location = new System.Drawing.Point(0, 0);
            this.crv_Product.Name = "crv_Product";
            this.crv_Product.Size = new System.Drawing.Size(752, 514);
            this.crv_Product.TabIndex = 0;
            this.crv_Product.Load += new System.EventHandler(this.crv_Product_Load);
            // 
            // GUI_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 514);
            this.Controls.Add(this.crv_Product);
            this.Name = "GUI_Print";
            this.Text = "GUI_Print";
            this.Load += new System.EventHandler(this.crv_Product_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product;

    }
}