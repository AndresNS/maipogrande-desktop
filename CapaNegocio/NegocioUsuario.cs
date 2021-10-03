using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "USUARIO";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarUsuarios()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarUsuario(Usuario usuario)
        {
            this.configurarConexion();
            String[] parametros = { "NOMBRE_USUARIO", "PASSWORD", "FECHA_CREACION", "ID_PERFIL", "ID_ESTD_CTA" };
            OracleDbType[] tipos= { OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Date, OracleDbType.Int32, OracleDbType.Int32 };
            Object[] valores = { usuario.NombreUsuario, usuario.Password, DateTime.Now, usuario.IdPerfil, usuario.IdEstadoCuenta };

            this.con.ejecutarProcedimiento("SP_INGRESAR_USUARIO", parametros, tipos, valores);
        }

        public void eliminarUsuario(int idUsuario)
        {
            this.configurarConexion();
            String[] parametros = { "ID" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { idUsuario };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_USUARIO", parametros, tipos, valores);
        }

        public void actualizarUsuario(Usuario usuario)
        {
            this.configurarConexion();
            String[] parametros = { "ID", "NOMBRE", "PASS", "FECHA", "PERFIL", "ESTD_CTA" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Date, OracleDbType.Int32, OracleDbType.Int32 };
            Object[] valores = { usuario.IdUsuario, usuario.NombreUsuario, usuario.Password, DateTime.Now, usuario.IdPerfil, usuario.IdEstadoCuenta };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_USUARIO", parametros, tipos, valores);
        }


        public Usuario buscarUsuario(int idUsuario)
        {
            Usuario usuario = new Usuario();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_USUARIO = " + idUsuario;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                usuario.IdUsuario = (int)dt.Rows[0]["ID_USUARIO"];
                usuario.NombreUsuario = (String)dt.Rows[0]["NOMBRE_USUARIO"];
                usuario.Password = (String)dt.Rows[0]["PASSWORD"];
                usuario.FechaCreacion = (DateTime)dt.Rows[0]["FECHA_CREACION"];
                usuario.IdPerfil = (short)dt.Rows[0]["ID_PERFIL"];
                usuario.IdEstadoCuenta = (short)dt.Rows[0]["ID_ESTD_CTA"];
            }
            catch (Exception ex)
            {
                Usuario auxUsuario = new Usuario();
                return auxUsuario;
            }

            return usuario;

        }
    }
}
