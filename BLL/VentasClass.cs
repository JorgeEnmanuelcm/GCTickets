using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class VentasClass : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public string Fecha { get; set; }
        public int Ticket { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int Total { get; set; }
        public List<EventosClass> VDetalle { get; set; }

        public VentasClass()
        {
            this.VentaId = 0;
            this.UsuarioId = 0;
            this.Fecha = "";
            this.Ticket = 0;
            this.Cantidad = 0;
            this.Descripcion = "";
            this.Total = 0;
            this.VDetalle = new List<EventosClass>();
        }

        public VentasClass(int ventaid, int usuarioid, string fecha, string descripcion, int cantidad, int total, int ticket)
        {
            this.VentaId = ventaid;
            this.UsuarioId = usuarioid;
            this.Fecha = fecha;
            this.Ticket = ticket;
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.Total = total;
        }

        public void AgregarVenta(int EventoId)
        {
            this.VDetalle.Add(new EventosClass(EventoId));
        }

        public override bool Insertar()
        {
            int Retorno = 0;
            object Identity;
            try
            {
                Identity = Conexion.ObtenerValor(String.Format("Insert Into Ventas(UsuarioId, Fecha, Ticket, Cantidad, Descripcion, Total) values({0}, '{1}', {2}, {3}, '{4}', {5}) select @@IDENTITY", this.UsuarioId, this.Fecha, this.Ticket, this.Cantidad, this.Descripcion, this.Total));
                int.TryParse(Identity.ToString(), out Retorno);
                this.VentaId = Retorno;
                if (Retorno > 0)
                {
                    foreach (EventosClass NumeroDatos in VDetalle)
                    {
                        Conexion.Ejecutar(String.Format("Insert into VentasDetalle(VentaId, EventoId) Values ({0}, {1})", Retorno, NumeroDatos.EventoId));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retorno > 0;
        }

        public override bool Editar()
        {
            bool Retorno = false;
            try
            {
                Retorno = Conexion.Ejecutar(String.Format("Update Ventas set UsuarioId={0}, Fecha='{1}', Ticket={2}, Cantidad={3}, Descripcion={4}, Total={5} where VentaId= {6}", this.UsuarioId, this.Fecha, this.Ticket, this.Cantidad, this.Descripcion, this.Total));
                if (Retorno)
                {
                    Conexion.Ejecutar(String.Format("Delete from VentasDetalle Where VentaId= {0}", this.VentaId));
                    foreach (EventosClass Numero in this.VDetalle)
                    {
                        Conexion.Ejecutar(string.Format("Insert into VentasDetalle(VentaId, EventoId) Values ({0},{1})", this.VentaId, Numero.EventoId));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retorno;
        }

        public override bool Eliminar()
        {
            bool Retorno = false;
            try
            {
                Retorno = Conexion.Ejecutar(String.Format("Delete from VentasDetalle Where VentaId= {0};" + "Delete from Ventas where VentaId= {0}", this.VentaId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Retorno;
        }


        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtVDetalle = new DataTable();
            try
            {
                dt = Conexion.ObtenerDatos(String.Format("select * from Ventas where VentaId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.VentaId = (int)dt.Rows[0]["VentaId"];
                    this.Fecha = dt.Rows[0]["Fecha"].ToString();
                    this.Ticket = (int)dt.Rows[0]["Ticket"];
                    this.Cantidad = (int)dt.Rows[0]["Cantidad"];
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                    this.Total = (int)dt.Rows[0]["Total"];
                    dtVDetalle = Conexion.ObtenerDatos(String.Format("select * from VentasDetalle where VentaId=" + IdBuscado));
                    dtVDetalle.Clear();
                    foreach (DataRow row in dtVDetalle.Rows)
                    {
                        AgregarVenta((int)dtVDetalle.Rows[0]["EventoId"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;
            return Conexion.ObtenerDatos("Select " + Campos + " From Ventas Where " + Condicion + Orden);
        }
    }
}
