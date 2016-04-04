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
    public partial class EventosForm : Form
    {
        EventosClass Evento = new EventosClass();
        ErrorProvider Error = new ErrorProvider();
        DialogResult SiNo = new DialogResult();
        
        public EventosForm()
        {
            InitializeComponent();
        }

        private void EventosForm_Load(object sender, EventArgs e)
        {
            TipoEventoClass TipoEvent = new TipoEventoClass();
            TipoEventocomboBox.DataSource = TipoEvent.Listado("*", "1=1", "");
            TipoEventocomboBox.DisplayMember = "Descripcion";
            TipoEventocomboBox.ValueMember = "TipoEventoId";

            Eliminarbutton.Enabled = false;
        }

        private void Limpiar()
        {
            EventoIdtextBox.Clear();
            NombreEventotextBox.Clear();
            LugarEventotextBox.Clear();
            EventodateTimePicker.ResetText();
            EventodataGridView.Rows.Clear();
            TipoEventocomboBox.SelectedIndex = -1;
            DescripciontextBox.Clear();
            CantDisptextBox.Clear();
            PrecioTtextBox.Clear();
            TipoEventocomboBox.ResetText();
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

        private bool ObtenerDatos()
        {
            bool Retorno = true;
            Error.Clear();
            if ((int)TipoEventocomboBox.SelectedValue > 0)
            {
                Evento.TipoEventoId = (int)TipoEventocomboBox.SelectedValue;
            }
            else
            {
                Error.SetError(TipoEventocomboBox, "Debe seleccionar un tipo de evento");
                Retorno = false;
            }
            if (NombreEventotextBox.Text.Length > 0)
            {
                Evento.NombreEvento = NombreEventotextBox.Text;
            }
            else
            {
                Error.SetError(NombreEventotextBox, "Debe ingresar un nombre al evento");
                Retorno = false;
            }
            if(EventodateTimePicker.Text.Length > 0)
            {
                Evento.FechaEvento = EventodateTimePicker.Text;
            }
            else
            {
                Error.SetError(EventodateTimePicker, "Debe ingresar una fecha al evento");
                Retorno = false;
            }
            if(LugarEventotextBox.Text.Length > 0)
            {
                Evento.LugarEvento = LugarEventotextBox.Text;
            }
            else
            {
                Error.SetError(LugarEventotextBox, "Debe Ingresar un lugar al evento");
                Retorno = false; 
            }
            if (EventodataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in EventodataGridView.Rows)
                {
                    Evento.AgregarTickets(item.Cells["Descripcion"].Value.ToString(), (int)item.Cells["CantDisponible"].Value, (int)item.Cells["PrecioTicket"].Value);
                    //EventodataGridView.Rows.Add(item.Descripcion, item.CantDisponible, item.PrecioTicket);
                }
            }
            else
            {
                MensajeError("Error al guardar debido a que no agrego taquillas!!!");
                Retorno = false;
            }

            return Retorno;
        }

        private void DevolverDatos()
        {
            TipoEventocomboBox.Text = Evento.TipoEventoId.ToString();
            NombreEventotextBox.Text = Evento.NombreEvento.ToString();
            EventodateTimePicker.Text = Evento.FechaEvento.ToString();
            LugarEventotextBox.Text = Evento.LugarEvento.ToString();
            foreach (var item in Evento.Detalle)
            {
                EventodataGridView.Rows.Add(item.Descripcion, item.CantDisponible, item.PrecioTicket);
            }

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            EventosClass Evento = new EventosClass();
            int cant = 0;
            int pre = 0;
            int.TryParse(CantDisptextBox.Text, out cant);
            int.TryParse(PrecioTtextBox.Text, out pre); 

            if (!DescripciontextBox.Text.Equals("") && !CantDisptextBox.Text.Equals("") && !PrecioTtextBox.Text.Equals(""))
            {
                EventodataGridView.Rows.Add(DescripciontextBox.Text, cant, pre);
               // Evento.AgregarTickets(DescripciontextBox.Text, cant, pre);
                DescripciontextBox.Clear();
                CantDisptextBox.Clear();
                PrecioTtextBox.Clear();
            }
            else
            {
                MensajeError("Error al agregar debido a que hay campos vacios!!!");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ObtenerDatos())
            {
                if (EventoIdtextBox.Text.Length == 0 && EventodataGridView.Rows.Count > 0)
                {
                    if (Evento.Insertar())
                    {
                        MensajeOk("Se han guardado los datos correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("No se ha podido guardar los datos");

                    }
                }
                if (EventoIdtextBox.Text.Length > 0 && EventodataGridView.Rows.Count > 0)
                {
                    if (Evento.Editar())
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
            Error.Clear();
            Limpiar();
            Guardarbutton.Text = "Guardar";
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SiNo = MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SiNo == System.Windows.Forms.DialogResult.Yes)
                {
                    if (EventoIdtextBox.Text.Length > 0 && Evento.Buscar(Evento.EventoId))
                    {
                        if (Evento.Eliminar())
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

        private void LugarEventotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(LugarEventotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                DescripciontextBox.Focus();
            }
        }

        private void NombreEventotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(NombreEventotextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                EventodateTimePicker.Focus();
            }
        }

        private void DescripciontextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 32) || (e.KeyChar == 13))
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
                CantDisptextBox.Focus();
            }
        }

        private void CantDisptextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(CantDisptextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                PrecioTtextBox.Focus();
            }
        }

        private void PrecioTtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(PrecioTtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Agregarbutton.Focus();
            }
        }

        private void EventoIdtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
            {
                e.Handled = false;
                Error.Clear();
            }
            else
            {
                e.Handled = true;
                Error.SetError(EventoIdtextBox, "Este campo no acepta el tipo de caracter que acaba de digitar");
            }
            if (e.KeyChar == 13)
            {
                Buscarbutton.Focus();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(EventoIdtextBox.Text, out id);
            if (id < 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Evento.Buscar(id))
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
    }
}
