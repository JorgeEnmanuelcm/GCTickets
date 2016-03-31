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
    public partial class UsuariosForm : Form
    {
        UsuariosClass Usuarios = new UsuariosClass();
        ErrorProvider Error = new ErrorProvider();
        DialogResult SiNo = new DialogResult();

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            TelefonomaskedTextBox.Clear();
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContraseniatextBox.Clear();
            ConfirmarContraseniatextBox.Clear();
            EsActivocheckBox.Checked = false;
            FotopictureBox.ImageLocation = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fotobutton_Click(object sender, EventArgs e)
        {
            FotoopenFileDialog.Filter = "Image Files|*.jpg; *.jpeg";
            FotoopenFileDialog.ShowDialog();
            if (FotoopenFileDialog.FileName != null)
            {
                FotopictureBox.ImageLocation = FotoopenFileDialog.FileName;
            }
        }

        public bool ObtenerDatos()
        {
            bool Retorno = true;
            Error.Clear();
            if (NombrestextBox.Text.Length > 0)
            {
                Usuarios.Nombres = NombrestextBox.Text;
            }
            else
            {
                Error.SetError(NombrestextBox, "Debe ingresar un nombres");
                Retorno = false;
            }
            if (ApellidostextBox.Text.Length > 0)
            {
                Usuarios.Apellidos = ApellidostextBox.Text;
            }
            else
            {
                Error.SetError(ApellidostextBox, "Debe ingresar apellidos");
                Retorno = false;
            }
            if (TelefonomaskedTextBox.Text.Length > 10)
            {
                Usuarios.Telefono = TelefonomaskedTextBox.Text;
            }
            else
            {
                Error.SetError(TelefonomaskedTextBox, "Debe ingresar un numero de telefono");
                Retorno = false;
            }
            if (EmailtextBox.Text.Length > 0)
            {
                Usuarios.Email = EmailtextBox.Text;
            }
            else
            {
                Error.SetError(EmailtextBox, "Debe ingresar un correo electronico");
                Retorno = false;
            }
            if (DirecciontextBox.Text.Length > 0)
            {
                Usuarios.Direccion = DirecciontextBox.Text;
            }
            else
            {
                Error.SetError(DirecciontextBox, "Debe ingresar una direccion");
                Retorno = false;
            }
            if (NombreUsuariotextBox.Text.Length > 0)
            {
                Usuarios.NombreUsuario = NombreUsuariotextBox.Text;
            }
            else
            {
                Error.SetError(NombreUsuariotextBox, "Debe ingresar un nombre de usuario");
                Retorno = false;
            }
            if (ContraseniatextBox.Text.Length > 0)
            {
                Usuarios.Contrasenia = ContraseniatextBox.Text;
            }
            else
            {
                Error.SetError(ContraseniatextBox, "Debe ingresar una contraseña");
                Retorno = false;
            }
            if (ConfirmarContraseniatextBox.Text.Length > 0)
            {
                Usuarios.ConfirmarContrasenia = ConfirmarContraseniatextBox.Text;
            }
            else
            {
                Error.SetError(ConfirmarContraseniatextBox, "Debe ingresar la misma contraseña para confirmar");
                Retorno = false;
            }
            if (EsActivocheckBox.Checked)
            {
                Usuarios.EsActivo = 1;
            }
            else
            {
                Usuarios.EsActivo = 0;
            }

            if (FotopictureBox.ImageLocation != null)
            {
                Usuarios.Foto = FotopictureBox.ImageLocation.ToString();
            }
            else
            {
                Error.SetError(FotopictureBox, "Debe ingresar una foto");
                Retorno = false;
            }
            return Retorno;
        }

        public void DevolverDatos()
        {
            NombrestextBox.Text = Usuarios.Nombres.ToString();
            ApellidostextBox.Text = Usuarios.Apellidos.ToString();
            TelefonomaskedTextBox.Text = Usuarios.Telefono.ToString();
            EmailtextBox.Text = Usuarios.Email.ToString();
            DirecciontextBox.Text = Usuarios.Direccion.ToString();
            NombreUsuariotextBox.Text = Usuarios.NombreUsuario.ToString();
            ContraseniatextBox.Text = Usuarios.Contrasenia.ToString();
            ConfirmarContraseniatextBox.Text = Usuarios.ConfirmarContrasenia.ToString();
            if (Usuarios.EsActivo == 1)
            {
                EsActivocheckBox.Checked = true;
            }
            else
            {
                EsActivocheckBox.Checked = false;
            }
            FotopictureBox.ImageLocation = Usuarios.Foto;
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SiNo = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SiNo == System.Windows.Forms.DialogResult.Yes)
                {
                    ObtenerDatos();
                    if (Usuarios.Buscar(Usuarios.UsuarioId))
                    {
                        if (Usuarios.Eliminar())
                        {
                            MensajeOk("Se ha eliminado correctamente");
                            Limpiar();
                            Guardarbutton.Text = "Guardar";
                            Eliminarbutton.Enabled = false;
                        }
                        else
                        {
                            MensajeError("Error al eliminar");
                        }
                    }
                    else
                    {
                        MensajeAdvertencia("Este Id no existe");
                        Limpiar();
                    }
                }
            }
            catch (Exception)
            {
                MensajeError("Error al eliminar");
            }
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(UsuarioIdtextBox.Text, out id);
            if (id < 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                if (Usuarios.Buscar(id))
                {
                    Guardarbutton.Text = "Modificar";
                    Eliminarbutton.Enabled = true;
                    DevolverDatos();
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado o no existe");
                    Limpiar();
                }
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            if (EsActivocheckBox.Checked == true)
            {
                Usuarios.EsActivo = 1;
            }
            else
            {
                Usuarios.EsActivo = 0;
            } 
            if (ContraseniatextBox.Text.Trim() != ConfirmarContraseniatextBox.Text.Trim())
            {
                Error.SetError(ContraseniatextBox, "Las contraseña no son identicas");
                Error.SetError(ConfirmarContraseniatextBox, "Las contraseña no son identicas");
                ConfirmarContraseniatextBox.Clear();
            }
            else
            {
                if (ObtenerDatos())
                {
                    if (UsuarioIdtextBox.Text.Length == 0)
                    {
                        if (Usuarios.Insertar())
                        {
                            MensajeOk("Se han guardado los datos correctamente");
                            Limpiar();
                        }
                        else
                        {
                            MensajeError("No se ha podido guardar datos");
                        }
                    }

                    if (UsuarioIdtextBox.Text.Length > 0)
                    {                        
                        if (Usuarios.Editar())
                        {
                            MensajeOk("Se han modificado los datos correctamente");
                            Eliminarbutton.Enabled = false;
                            Guardarbutton.Text = "Guardar";
                            Limpiar();
                        }
                        else
                        {
                            MensajeError("No se ha podido modificar los datos");
                            Limpiar();
                        }
                    }
                }
            }
        
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
            Error.Clear();
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
        }

        private void UsuarioIdtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(UsuarioIdtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
            }
        }

        private void ApellidostextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(ApellidostextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                TelefonomaskedTextBox.Focus();
            }
        }

        private void NombrestextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(NombrestextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ApellidostextBox.Focus();
            }
        }

        private void DirecciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 35) || (e.KeyChar == 44) || (e.KeyChar == 46) || (e.KeyChar == 47) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(DirecciontextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                NombreUsuariotextBox.Focus();
            }
        }

        private void EmailtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 64) || (e.KeyChar == 46) || (e.KeyChar == 95) || (e.KeyChar == 45) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(EmailtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                DirecciontextBox.Focus();
            }
        }


        private void ConfirmarContraseniatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(ConfirmarContraseniatextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Fotobutton.Focus();
            }
        }

        private void ContraseniatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(ContraseniatextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ConfirmarContraseniatextBox.Focus();
            }
        }

        private void NombreUsuariotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 95) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(NombreUsuariotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                ContraseniatextBox.Focus();
            }
        }

        private void TelefonomaskedTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(TelefonomaskedTextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                EmailtextBox.Focus();
            }
        }

        private void NombreUsuariotextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if (e.KeyCode == keys.Enter)
            //{
            //    if (this.GetNextControl(ActiveControl, true) != null)
            //    {
            //        e.Handled = true;
            //        this.GetNextControl(ActiveControl, true).Focus();
            //    }
            //}
        }
    }
}
