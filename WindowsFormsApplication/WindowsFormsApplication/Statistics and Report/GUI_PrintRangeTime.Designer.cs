namespace WindowsFormsApplication.Statistics_and_Report
{
    partial class GUI_PrintRangeTime
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
            this.crv_Range = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Range
            // 
            this.crv_Range.ActiveViewIndex = -1;
            this.crv_Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Range.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Range.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Range.Location = new System.Drawing.Point(0, 0);
            this.crv_Range.Name = "crv_Range";
            this.crv_Range.Size = new System.Drawing.Size(941, 646);
            this.crv_Range.TabIndex = 0;
            this.crv_Range.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_Range.Load += new System.EventHandler(this.crv_Range_Load);
            // 
            // GUI_PrintRangeTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 646);
            this.Controls.Add(this.crv_Range);
            this.Name = "GUI_PrintRangeTime";
            this.Text = "GUI_PrintRangeTime";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Range;
    }
}