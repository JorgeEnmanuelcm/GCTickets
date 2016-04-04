using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GCTickets.Registros
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            EventosClass evento = new EventosClass();
            EventocomboBox.DataSource = evento.Listado("*", "1=1", "");
            EventocomboBox.DisplayMember = "NombreEvento";
            EventocomboBox.ValueMember = "EventoId";

            EventosDetalleClass det = new EventosDetalleClass();
            TicketcomboBox.DataSource = det.Listado("*", "1=1", "");
            TicketcomboBox.DisplayMember = "Descripcion";
            TicketcomboBox.ValueMember = "PrecioTicket";
        }
    }
}
