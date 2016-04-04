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
        ErrorProvider Error = new ErrorProvider();
        DialogResult SiNo = new DialogResult();
        VentasClass Venta = new VentasClass();

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

            FechadateTimePicker.Enabled = false;
            Eliminarbutton.Enabled = false;
            Imprimirbutton.Enabled = false;

            EventosDetalleClass det = new EventosDetalleClass();
            TicketcomboBox.DataSource = det.Listado("*", "1=1", "");
            TicketcomboBox.DisplayMember = "Descripcion";
            TicketcomboBox.ValueMember = "PrecioTicket";


            UsuariosClass usuario = new UsuariosClass();
            UsuarioscomboBox.DataSource = usuario.Listado("*", "1=1", "");
            UsuarioscomboBox.DisplayMember = "NombreUsuario";
            UsuarioscomboBox.ValueMember = "UsuarioId";
        }

        private void CanttextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(CanttextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }

        private void DescripcionrichTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 46) || (e.KeyChar == 44) || (e.KeyChar == 32))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(DescripcionrichTextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
        }

        private void VentaIdtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(VentaIdtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
            }
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

        private void Limpiar()
        {
            //UsuarioscomboBox.SelectedIndex = -1;
            //EventocomboBox.SelectedIndex = -1;
            //TicketcomboBox.SelectedIndex = -1;

            EventocomboBox.ResetText();
            TotaltextBox.Clear();
            VentaIdtextBox.Clear();
            CanttextBox.Clear();
            VentadataGridView.Rows.Clear();
        }

        private bool ObtenerDatos()
        {
            int cant;
            int.TryParse(CanttextBox.Text, out cant);
            int total;
            int.TryParse(TotaltextBox.Text, out total);
            bool Retorno = true;
            Error.Clear();
            if ((int)UsuarioscomboBox.SelectedValue > 0)
            {
                Venta.UsuarioId = (int)UsuarioscomboBox.SelectedValue;
            }
            else
            {
                Error.SetError(UsuarioscomboBox, "Debe seleccionar un usuario");
                Retorno = false;
            }
            if (FechadateTimePicker.Text.Length > 0)
            {
                Venta.Fecha = FechadateTimePicker.Text;
            }
            else
            {
                Error.SetError(FechadateTimePicker, "Debe ingresar una fecha al evento");
                Retorno = false;
            }
            if ((int)TicketcomboBox.SelectedValue > 0)
            {
                Venta.Ticket = (int)TicketcomboBox.SelectedValue;
            }
            else
            {
                Error.SetError(TicketcomboBox, "Debe seleccionar un ticket");
                Retorno = false;
            }
            if (CanttextBox.Text.Length > 0)
            {
                Venta.Cantidad = cant;
            }
            else
            {
                Error.SetError(CanttextBox, "Debe Ingresar una cantidad");
                Retorno = false;
            }
            if (DescripcionrichTextBox.Text.Length > 0)
            {
                Venta.Descripcion = DescripcionrichTextBox.Text;
            }
            else
            {
                Error.SetError(DescripcionrichTextBox, "Debe Ingresar una descripcion");
                Retorno = false;
            }
            if (TotaltextBox.Text.Length > 0)
            {
                Venta.Total = total;
            }
            else
            {
                Error.SetError(TotaltextBox, "Debe Ingresar un total");
                Retorno = false;
            }
            if (VentadataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in VentadataGridView.Rows)
                {
                    Venta.AgregarVenta((int)item.Cells["EventoId"].Value);
                }
            }
            else
            {
                MensajeError("Error al guardar debido a que no agrego un evento!!!");
                Retorno = false;
            }

            return Retorno;
        }

        private void DevolverDatos()
        {
            UsuarioscomboBox.Text = Venta.UsuarioId.ToString();
            FechadateTimePicker.Text = Venta.Fecha.ToString();
            TicketcomboBox.Text = Venta.Ticket.ToString();
            CanttextBox.Text = Venta.Cantidad.ToString();
            DescripcionrichTextBox.Text = Venta.Descripcion.ToString();
            TotaltextBox.Text = Venta.Total.ToString();
            foreach (var item in Venta.VDetalle)
            {
                VentadataGridView.Rows.Add(item.EventoId);
            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Error.Clear();
            Eliminarbutton.Enabled = false;
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            VentadataGridView.Rows.Add(EventocomboBox.SelectedValue, EventocomboBox.Text);
            int precio = 0;
            int cantidad = 0;
            int.TryParse(TicketcomboBox.SelectedValue.ToString(),out precio);
            int.TryParse(CanttextBox.Text,out cantidad);
            TotaltextBox.Text = (precio * cantidad).ToString();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SiNo = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SiNo == System.Windows.Forms.DialogResult.Yes)
                {
                    if (VentaIdtextBox.Text.Length > 0 && Venta.Buscar(Venta.VentaId))
                    {
                        if (Venta.Eliminar())
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
            int.TryParse(VentaIdtextBox.Text, out id);
            if (id < 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Venta.Buscar(id))
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ObtenerDatos())
            {
                if (VentaIdtextBox.Text.Length == 0 && VentadataGridView.Rows.Count > 0)
                {
                    if (Venta.Insertar())
                    {
                        MensajeOk("Se han guardado los datos correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("No se ha podido guardar los datos");

                    }
                }
                if (VentaIdtextBox.Text.Length > 0 && VentadataGridView.Rows.Count > 0)
                {
                    if (Venta.Editar())
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
}
