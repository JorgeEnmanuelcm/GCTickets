namespace GCTickets
{
    partial class TipoEventoReporteVisor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoEventoReporteVisor));
            this.TipoEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GCTicketsDbDataSet = new GCTickets.GCTicketsDbDataSet();
            this.TipoEventoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TipoEventoTableAdapter = new GCTickets.GCTicketsDbDataSetTableAdapters.TipoEventoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCTicketsDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoEventoBindingSource
            // 
            this.TipoEventoBindingSource.DataMember = "TipoEvento";
            this.TipoEventoBindingSource.DataSource = this.GCTicketsDbDataSet;
            // 
            // GCTicketsDbDataSet
            // 
            this.GCTicketsDbDataSet.DataSetName = "GCTicketsDbDataSet";
            this.GCTicketsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TipoEventoreportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TipoEventoBindingSource;
            this.TipoEventoreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.TipoEventoreportViewer.LocalReport.ReportEmbeddedResource = "GCTickets.Reportes.TipoEventoReport.rdlc";
            this.TipoEventoreportViewer.Location = new System.Drawing.Point(1, 3);
            this.TipoEventoreportViewer.Name = "TipoEventoreportViewer";
            this.TipoEventoreportViewer.Size = new System.Drawing.Size(424, 257);
            this.TipoEventoreportViewer.TabIndex = 0;
            // 
            // TipoEventoTableAdapter
            // 
            this.TipoEventoTableAdapter.ClearBeforeFill = true;
            // 
            // TipoEventoReporteVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.TipoEventoreportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoEventoReporteVisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Evento Reporte";
            this.Load += new System.EventHandler(this.TipoEventoReporteVisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCTicketsDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TipoEventoreportViewer;
        private System.Windows.Forms.BindingSource TipoEventoBindingSource;
        private GCTicketsDbDataSet GCTicketsDbDataSet;
        private GCTicketsDbDataSetTableAdapters.TipoEventoTableAdapter TipoEventoTableAdapter;
    }
}