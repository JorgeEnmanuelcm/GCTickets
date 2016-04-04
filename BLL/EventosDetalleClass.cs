using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class EventosDetalleClass
    {
        //[Browsable(false)]
        public int Id { get; set; }
        //[Browsable(false)]
        public int EventoId { get; set; }

        public string Descripcion { get; set; }
        public int CantDisponible { get; set; }
        public int PrecioTicket { get; set; }

        public EventosDetalleClass()
        {
            this.Id = 0;
            this.EventoId = 0;
            this.Descripcion = "";
            this.CantDisponible = 0;
            this.PrecioTicket = 0;
        }

        public EventosDetalleClass(string descripcion, int cantdisponible, int precioticket)
        {
            this.Descripcion = descripcion;
            this.CantDisponible = cantdisponible;
            this.PrecioTicket = precioticket;
        }

        public DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb Conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;
            return Conexion.ObtenerDatos("Select " + Campos + " From EventosDetalle Where " + Condicion + Orden);
        }

    }
}
