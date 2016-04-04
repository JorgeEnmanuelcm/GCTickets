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
    public partial class TipoEventoConsulta : Form
    { 
        public TipoEventoConsulta()
        {
            InitializeComponent();
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Error.Clear();
            TipoEventoClass Consulta = new TipoEventoClass();
            string filtro = "1=1";
            if (BuscartextBox.Text.Length > 0)
            {
                if(BuscarcomboBox.SelectedIndex == 0)
                {
                    filtro ="TipoEventoId like '%" + BuscartextBox.Text + "%'";
                }
                else if(BuscarcomboBox.SelectedIndex == 1)
                {
                    filtro = "Descripcion like '%" + BuscartextBox.Text + "%'";
                }
            }
            TipoEventodataGridView.DataSource = Consulta.Listado("TipoEventoId, Descripcion", filtro, "");
            CanttextBox.Text = TipoEventodataGridView.RowCount.ToString();
            }

        private void TipoEventoConsulta_Load(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            TipoEventoReporteVisor visor = new TipoEventoReporteVisor();
            visor.Show();
        }
    }
    }

