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
    public partial class UsuariosConsulta : Form
    {
        public UsuariosConsulta()
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
            UsuariosClass Consulta = new UsuariosClass();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (BuscarcomboBox.SelectedIndex == 0)
                {
                    filtro = "UsuarioId like '%" + BuscartextBox.Text + "%'";
                }
                else if (BuscarcomboBox.SelectedIndex == 1)
                {
                    filtro = "Nombres like '%" + BuscartextBox.Text + "%'";
                }
                else if(BuscarcomboBox.SelectedIndex == 2)
                {
                    filtro = "Apellidos like '%" + BuscartextBox.Text + "%'";
                }
                else if (BuscarcomboBox.SelectedIndex == 3)
                {
                    filtro = "NombreUsuario like '%" + BuscartextBox.Text + "%'";
                }
            }
            UsuariosdataGridView.DataSource = Consulta.Listado("UsuarioId, Nombres, Apellidos, Telefono, Email, Direccion, NombreUsuario, Contrasenia, ConfirmarContrasenia, EsActivo, Foto", filtro, "");
            CanttextBox.Text = UsuariosdataGridView.RowCount.ToString();
        }

        private void Buscarlabel_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosConsulta_Load(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = true;
        }
    }
}
