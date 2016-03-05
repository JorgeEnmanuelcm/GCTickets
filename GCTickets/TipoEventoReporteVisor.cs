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
    public partial class TipoEventoReporteVisor : Form
    {
        public TipoEventoReporteVisor()
        {
            InitializeComponent();
        }

        private void TipoEventoReporteVisor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GCTicketsDbDataSet.TipoEvento' table. You can move, or remove it, as needed.
            this.TipoEventoTableAdapter.Fill(this.GCTicketsDbDataSet.TipoEvento);

            this.TipoEventoreportViewer.RefreshReport();
        }
    }
}
