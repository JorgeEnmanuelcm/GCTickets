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

        private void BuscartextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            UsuariosClass Consulta = new UsuariosClass();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = BuscarcomboBox.Text + " like '%" + BuscarcomboBox.Text + "%'";
            }

            UsuariosdataGridView.DataSource = Consulta.Listado("UsuarioId, Nombres, Apellidos, Telefono, Email, Direccion, NombreUsuario, Contrasenia, ConfirmarContrasenia, EsActivo, Foto", filtro, "");
            CanttextBox.Text = UsuariosdataGridView.RowCount.ToString();
        }

        private void Buscarlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
