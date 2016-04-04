using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EventosClass : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int EventoId { get; set; }
        public int TipoEventoId { get; set; }
        public string NombreEvento { get; set; }
        public string FechaEvento { get; set; }
        public string LugarEvento { get; set; }
        public string Descripcion { get; set; }
        public int CantDisponible { get; set; }
        public int PrecioTicket { get; set; }
        public List<EventosDetalleClass> Detalle { get; set; }

        public EventosClass()
        {
            this.EventoId = 0;
            this.TipoEventoId = 0;
            this.NombreEvento = "";
            this.FechaEvento = "";
            this.LugarEvento = "";
            this.Descripcion = "";
            this.CantDisponible = 0;
            this.PrecioTicket = 0;
            this.Detalle = new List<EventosDetalleClass>();
        }

        public EventosClass(int eventoid)
        {
            this.EventoId = eventoid;
            //this.TipoEventoId = tipoeventoid;
            //this.NombreEvento = nombreevento;
            //this.FechaEvento = fechaevento;
            //this.LugarEvento = lugarevento;
            //, int tipoeventoid, string nombreevento, string fechaevento, string lugarevento

        }

        public void AgregarTickets(string Descripcion, int CantDisponible, int PrecioTicket)
        {
            this.Detalle.Add(new EventosDetalleClass(Descripcion, CantDisponible, PrecioTicket));
        }

        public override bool Insertar()
        {
            int Retorno = 0;
            object Identity;
            try
            {
                Identity = Conexion.ObtenerValor(String.Format("Insert Into Eventos(TipoEventoId, NombreEvento, FechaEvento, LugarEvento) values({0}, '{1}', '{2}', '{3}') select @@IDENTITY", this.TipoEventoId, this.NombreEvento, this.FechaEvento, this.LugarEvento));
                int.TryParse(Identity.ToString(), out Retorno);
                this.EventoId = Retorno;
                if (Retorno > 0)
                {
                    foreach (EventosDetalleClass NumeroDatos in Detalle)
                    {
                        Conexion.Ejecutar(String.Format("Insert into EventosDetalle(EventoId, Descripcion, CantDisponible, PrecioTicket) Values ({0}, '{1}', {2}, {3})", Retorno, NumeroDatos.Descripcion, NumeroDatos.CantDisponible, NumeroDatos.PrecioTicket));
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
                Retorno = Conexion.Ejecutar(String.Format("Update Eventos set TipoEventoId={0}, NombreEvento='{1}', FechaEvento='{2}', LugarEvento='{3}' where EventoId= {4}", this.TipoEventoId, this.NombreEvento, this.FechaEvento, this.LugarEvento, this.EventoId));
                if (Retorno)
                {
                    Conexion.Ejecutar(String.Format("Delete from EventosDetalle Where EventoId= {0}", this.EventoId));
                    foreach (EventosDetalleClass Numero in this.Detalle)
                    {
                        Conexion.Ejecutar(string.Format("Insert into EventosDetalle(EventoId, Descripcion, CantDisponible, PrecioTicket) Values ({0},'{1}',{2},{3})", this.EventoId, Numero.Descripcion, Numero.CantDisponible, Numero.PrecioTicket));
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
                Retorno = Conexion.Ejecutar(String.Format("Delete from EventosDetalle Where EventoId= {0};" + "Delete from Eventos where EventoId= {0}", this.EventoId));
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
            DataTable dtEventDetalle = new DataTable();
            try
            {
                dt = Conexion.ObtenerDatos(String.Format("select * from Eventos where EventoId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.EventoId= (int)dt.Rows[0]["EventoId"];
                    this.NombreEvento = dt.Rows[0]["NombreEvento"].ToString();
                    this.FechaEvento = dt.Rows[0]["FechaEvento"].ToString();
                    this.LugarEvento = dt.Rows[0]["LugarEvento"].ToString();
                    dtEventDetalle = Conexion.ObtenerDatos(String.Format("select * from EventosDetalle where EventoId=" + IdBuscado));
                    dtEventDetalle.Clear();
                    foreach (DataRow row in dtEventDetalle.Rows)
                    {
                        AgregarTickets(row["Descripcion"].ToString(), (int)dtEventDetalle.Rows[0]["CantDisponible"], (int)dtEventDetalle.Rows[0]["PrecioTicket"]);
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
            return Conexion.ObtenerDatos("Select " + Campos + " From Eventos Where " + Condicion + Orden);
        }
    }
}
