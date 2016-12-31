namespace WindowsFormsApplication.Statistics_and_Report
{
    partial class GUI_PrintDay
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
            this.crv_reportday = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_reportday
            // 
            this.crv_reportday.ActiveViewIndex = -1;
            this.crv_reportday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_reportday.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_reportday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_reportday.Location = new System.Drawing.Point(0, 0);
            this.crv_reportday.Name = "crv_reportday";
            this.crv_reportday.Size = new System.Drawing.Size(945, 641);
            this.crv_reportday.TabIndex = 0;
            this.crv_reportday.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_reportday.Load += new System.EventHandler(this.crv_reportday_Load);
            // 
            // GUI_PrintDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 641);
            this.Controls.Add(this.crv_reportday);
            this.Name = "GUI_PrintDay";
            this.Text = "GUI_PrintDay";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_reportday;
    }
}