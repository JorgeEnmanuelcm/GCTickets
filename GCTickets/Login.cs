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
    public partial class Login : Form
    {
        ErrorProvider Error = new ErrorProvider();
        UsuariosClass Usuario = new UsuariosClass();
        PortadaPrincipal Portada = new PortadaPrincipal();

        public Login()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            NombreUsuariotextBox.Clear();
            ContraseniatextBox.Clear();
            Error.Clear();         
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public bool ObtenerDatos()
        {
            bool Retorno = true;
            Error.Clear();
            if (NombreUsuariotextBox.Text.Length > 0)
            {
                Usuario.NombreUsuario = NombreUsuariotextBox.Text;
            }
            else
            {
                Error.SetError(NombreUsuariotextBox, "Debe ingresar un nombre de usuario");
                Retorno = false;
            }
            if (ContraseniatextBox.Text.Length > 0)
            {
                Usuario.Contrasenia = ContraseniatextBox.Text;
            }
            else
            {
                Error.SetError(ContraseniatextBox, "Debe ingresar una contraseña");
                Retorno = false;
            }
            return Retorno;
        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
                if (ObtenerDatos())
                {
                if (Usuario.LoginUsuario())
                {
                    if(NombreUsuariotextBox.Text == Usuario.NombreUsuario &&  ContraseniatextBox.Text == Usuario.Contrasenia)
                    {
                        Portada.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        Error.SetError(NombreUsuariotextBox, "El usuario y la contraseña no coinciden por favor intente de nuevo");
                        Error.SetError(ContraseniatextBox, "El usuario y la contraseña no coinciden por favor intente de nuevo");
                    }
                }
            }
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NombreUsuariotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(NombreUsuariotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }

        private void ContraseniatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(ContraseniatextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }
    }
}
