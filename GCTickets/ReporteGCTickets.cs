using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCTickets
{
    public partial class ReporteGCTickets : Form
    {

        public string Reporte { get; set; }
        public DataTable Data { get; set; }

        public ReporteGCTickets()
        {
            InitializeComponent();
        }

        private void ReporteGCTickets_Load(object sender, EventArgs e)
        {

            this.GCTicketsreportViewer.RefreshReport();
        }

        private void GCTicketsreportViewer_Load(object sender, EventArgs e)
        {
            this.GCTicketsreportViewer.Reset();
            this.GCTicketsreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.GCTicketsreportViewer.LocalReport.ReportPath = this.Reporte;
            ReportDataSource source = new ReportDataSource(this.Data.TableName, this.Data);
            this.GCTicketsreportViewer.LocalReport.DataSources.Add(source);
            this.GCTicketsreportViewer.RefreshReport();
        }
    }
}
