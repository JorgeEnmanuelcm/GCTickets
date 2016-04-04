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

namespace GCTickets.Consultas
{
    public partial class VentasConsultaForm : Form
    {
        public VentasConsultaForm()
        {
            InitializeComponent();
        }

        private void Cantlabel_Click(object sender, EventArgs e)
        {

        }

        ErrorProvider Error = new ErrorProvider();

        private void BuscartextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 13) || (e.KeyChar == 127) || (e.KeyChar == 32))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(BuscartextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
            }
        }

        private void BuscarcomboBox_TextChanged(object sender, System.EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }

        private void VentasConsultaForm_Load(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = true;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Error.Clear();
            VentasClass Consulta = new VentasClass();
            string filtro = "1=1";
            if (BuscartextBox.Text.Length > 0)
            {
                if (BuscarcomboBox.SelectedIndex == 0)
                {
                    filtro = "VentaId like '%" + BuscartextBox.Text + "%'";
                }
                else if (BuscarcomboBox.SelectedIndex == 1)
                {
                    filtro = "UsuarioId like '%" + BuscartextBox.Text + "%'";
                }

            }
            VentasdataGridView.DataSource = Consulta.Listado("VentaId, UsuarioId, Fecha, Ticket, Cantidad, Descripcion, Total", filtro, "");
            CanttextBox.Text = VentasdataGridView.RowCount.ToString();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteGCTickets reporte = new ReporteGCTickets();
            DataTable dt = new DataTable();
            dt = (DataTable)VentasdataGridView.DataSource;
            dt.TableName = "VentasDataSet";
            reporte.Reporte = "VentasReport.rdlc";
            reporte.Data = dt;
            reporte.ShowDialog();
        }
    }
    }

