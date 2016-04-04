namespace GCTickets
{
    partial class ReporteGCTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteGCTickets));
            this.GCTicketsreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // GCTicketsreportViewer
            // 
            this.GCTicketsreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCTicketsreportViewer.Location = new System.Drawing.Point(0, 0);
            this.GCTicketsreportViewer.Name = "GCTicketsreportViewer";
            this.GCTicketsreportViewer.Size = new System.Drawing.Size(618, 335);
            this.GCTicketsreportViewer.TabIndex = 0;
            this.GCTicketsreportViewer.Load += new System.EventHandler(this.GCTicketsreportViewer_Load);
            // 
            // ReporteGCTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 335);
            this.Controls.Add(this.GCTicketsreportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteGCTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte GC Tickets";
            this.Load += new System.EventHandler(this.ReporteGCTickets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer GCTicketsreportViewer;
    }
}