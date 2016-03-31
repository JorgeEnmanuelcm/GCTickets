using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsuariosClass : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();

        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string ConfirmarContrasenia { get; set; }
        public int EsActivo { get; set; }
        public string Foto { get; set; }

        public UsuariosClass()
        {
            this.UsuarioId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Telefono = "";
            this.Email = "";
            this.Direccion = "";
            this.NombreUsuario = "";
            this.Contrasenia = "";
            this.ConfirmarContrasenia = "";
            this.EsActivo = 0;
            this.Foto = "";
        }

        public UsuariosClass(int usuarioid, string nombres, string apellidos, string telefono, string email, string direccion, string nombreusuario, string contrasenia, string confirmarcontrasenia, int esactivo, string foto)
        {
            this.UsuarioId = usuarioid;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
            this.Direccion = direccion;
            this.NombreUsuario = nombreusuario;
            this.Contrasenia = contrasenia;
            this.ConfirmarContrasenia = confirmarcontrasenia;
            this.EsActivo = esactivo;
            this.Foto = foto;   
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Insert Into Usuarios (Nombres, Apellidos, Telefono, Email, Direccion, NombreUsuario, Contrasenia, ConfirmarContrasenia, EsActivo, Foto) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}')", this.Nombres, this.Apellidos, this.Telefono, this.Email, this.Direccion, this.NombreUsuario, this.Contrasenia, this.ConfirmarContrasenia, this.EsActivo, this.Foto));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Update Usuarios set Nombres='{0}', Apellidos='{1}', Telefono='{2}', Email='{3}', Direccion='{4}', NombreUsuario='{5}', Contrasenia='{6}', ConfirmarContrasenia='{7}', EsActivo={8}, Foto='{9}' where UsuarioId={10}", this.Nombres, this.Apellidos, this.Telefono, this.Email, this.Direccion, this.NombreUsuario, this.Contrasenia, this.ConfirmarContrasenia, this.EsActivo, this.Foto, this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId={0}", this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public static int Enteros(string NumeroEntero)
        {
            int numero;
            int.TryParse(NumeroEntero, out numero);
            return numero;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = Conexion.ObtenerDatos("Select * from Usuarios Where UsuarioId=" + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.UsuarioId = Enteros(dt.Rows[0]["UsuarioId"].ToString());
                    this.Nombres = dt.Rows[0]["Nombres"].ToString();
                    this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    this.Telefono = dt.Rows[0]["Telefono"].ToString();
                    this.Email = dt.Rows[0]["Email"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                    this.Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
                    this.ConfirmarContrasenia = dt.Rows[0]["ConfirmarContrasenia"].ToString();
                    this.EsActivo = Enteros(dt.Rows[0]["EsActivo"].ToString());
                    this.Foto = dt.Rows[0]["Foto"].ToString();
                }
            }catch(Exception ex) { throw ex; }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
           string ordenar = "";
           if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
           return Conexion.ObtenerDatos(("Select " + Campos + " from Usuarios where " + Condicion + ordenar));
        }

        public bool UnicoNombreUs(string UnicoNom)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Conexion.ObtenerDatos(string.Format("select * from Usuarios where NombreUsuario= '" + UnicoNom + "'"));
                if (dt.Rows.Count > 0)
                {
                    this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                    this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public bool LoginUsuario()
        {
           DataTable dt = new DataTable ();
           try
           {
               dt = Conexion.ObtenerDatos("Select NombreUsuario, Contrasenia from Usuarios where NombreUsuario='"+this.NombreUsuario+"' and Contrasenia='"+this.Contrasenia+"'");
               this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
               this.Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
           }
           catch (Exception)
           {
                return false;
           }
           return true;
       }
    }
}
