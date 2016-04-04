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
        DialogResult SiNo = new DialogResult();

        public TipoEventoForm()
        {
            InitializeComponent();
        }

        private void DescripciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 46) || (e.KeyChar == 44) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(DescripciontextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Guardarbutton.Focus();
            }
        }

        private void IdTipoEventotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(IdTipoEventotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
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
            MessageBox.Show(mensaje, "Registro de Tipo Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Eventos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipo Eventos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (TipoEvento.UnicaDescripcion(DescripciontextBox.Text))
            {
                MessageBox.Show("Esta Descripcion ya existe!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DescripciontextBox.Clear();
            }
            else
            {
            if (ObtenerDatos())
            {
                if (IdTipoEventotextBox.Text.Length == 0)
                {
                    if (TipoEvento.Insertar())
                    {
                        MensajeOk("Se han guardado los datos correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("No se ha podido guardar los datos");

                    }
                }
                if (IdTipoEventotextBox.Text.Length > 0)
                {
                    if (TipoEvento.Editar())
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SiNo = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SiNo == System.Windows.Forms.DialogResult.Yes)
                {
                    ObtenerDatos();
                    if (TipoEvento.Buscar(TipoEvento.TipoEventoId))
                    {
                        if (TipoEvento.Eliminar())
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
