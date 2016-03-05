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
    public partial class TipoEventoForm : Form
    {
        ErrorProvider Error = new ErrorProvider();
        TipoEventoClass TipoEvento = new TipoEventoClass();

        public TipoEventoForm()
        {
            InitializeComponent();
        }

        private void DescripciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                Error.SetError(DescripciontextBox, "Este campo no acepta numeros ni caracteres especiales");
            }
        }

        private void IdTipoEventotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                Error.SetError(IdTipoEventotextBox, "Este campo solo acepta numeros");
            }
        }

        private void Limpiar()
        {
            IdTipoEventotextBox.Clear();
            DescripciontextBox.Clear();
        }

        private bool ObtenerDatos()
        {
            bool Retorno = true;
            Error.Clear();
            if (DescripciontextBox.Text.Length > 0)
            {
                TipoEvento.Descripcion = DescripciontextBox.Text;
            }
            else
            {
                Error.SetError(DescripciontextBox, "Debe ingresar una descripcion");
                Retorno = false;
            }

            return Retorno;
        }

        private void DevolverDatos()
        {
            DescripciontextBox.Text = TipoEvento.Descripcion.ToString();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ObtenerDatos())
            {
                if (IdTipoEventotextBox.Text.Length == 0)
                {
                    if (TipoEvento.Insertar())
                    {
                        MensajeOk("Se han insertado los datos correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("No se han podido insertar datos");

                    }
                }
                if (IdTipoEventotextBox.Text.Length > 0)
                {
                    if (TipoEvento.Editar())
                    {
                        MensajeOk("Se han modificado los datos correctamente");
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos();
                if (TipoEvento.Buscar(TipoEvento.TipoEventoId))
                {
                    if (TipoEvento.Eliminar())
                    {
                        MensajeOk("Se ha eliminado correctamente");
                        Limpiar();
                        Guardarbutton.Text = "Guardar";
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
            catch (Exception)
            {
                MensajeError("Error al eliminar");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdTipoEventotextBox.Text, out id);
            if (id < 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            if (TipoEvento.Buscar(id))
            {
                Eliminarbutton.Enabled = true;
                Guardarbutton.Text = "Modificar";
                DevolverDatos();
            }
            else
            {
                MensajeAdvertencia("Id no encontrado o no existe");
                Limpiar();
            }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Error.Clear();
            Eliminarbutton.Enabled = false;
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void TipoEventoForm_Load(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
        }
    }
}
