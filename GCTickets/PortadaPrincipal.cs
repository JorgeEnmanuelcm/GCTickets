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

namespace GCTickets
{
    public partial class PortadaPrincipal : Form
    {
        public PortadaPrincipal()
        {
            InitializeComponent();
        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm Usuarios = new Registros.UsuariosForm();
            //Usuarios.MdiParent = this;
            Usuarios.Show();
        }

        private void registroTipoEvenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.TipoEventoForm TipoEvento = new Registros.TipoEventoForm();
            TipoEvento.Show();
        }

        private void tipoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.TipoEventoConsulta Consulta = new Consultas.TipoEventoConsulta();
            Consulta.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.UsuariosConsulta Consult = new Consultas.UsuariosConsulta();
            Consult.Show();
        }

        private void tipoEventoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TipoEventoReporteVisor Visor = new TipoEventoReporteVisor();
            Visor.Show();
        }

        private void PortadaPrincipal_Load(object sender, System.EventArgs e)
        {
            
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm Reg = new Registros.UsuariosForm();
            Reg.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GCTicketsAboutBox AcercaDe = new GCTicketsAboutBox();
            AcercaDe.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void registroEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.EventosForm Evento = new Registros.EventosForm();
            Evento.Show(); 
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.EventosConsultaForm consu = new Consultas.EventosConsultaForm();
            consu.Show();
        }

        private void Usuariolabel_Click(object sender, EventArgs e)
        {

        }

        private void registroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.VentasForm venta = new Registros.VentasForm();
            venta.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm ayuda = new AyudaForm();
            ayuda.Show();
        }

        private void VentatoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.VentasForm venta = new Registros.VentasForm();
            venta.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.VentasConsultaForm consultaVenta = new Consultas.VentasConsultaForm();
            consultaVenta.Show();
        }
    }
}
