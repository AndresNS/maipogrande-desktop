using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;


namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }
       
        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "hr";
            this.con.NombreTabla = "maipo_grande";
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
            this.con.CadenaSQL = "INSERT INTO "+ this.con.NombreTabla + " "
                                   + "(ID_USUARIO, PASSWORD, FECHA_CREACION, ID_PERFIL, ID_ESTD_CTA) "
                                   + "VALUES "
                                   + "(" + usuario.IdUsuario + ","
                                   + "'" + usuario.Password + "',"
                                   + "'" + usuario.FechaCreacion + "',"
                                    + usuario.IdPerfil + ","
                                    + usuario.IdEstadoCuenta + ");";
            this.con.EsSelect = false;
            this.con.conectar();
        }


        public void eliminarUsuario(int idUsuario)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "DELETE FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_USUARIO = " + idUsuario + ";";
            this.con.EsSelect = false;
            this.con.conectar();
        }

        public void actualizarCliente(Usuario usuario)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "UPDATE " + this.con.NombreTabla + " "
                                   + "SET "
                                   + "PASSWORD = '" + usuario.Password + "',"
                                   + "FECHA_CREACION = '" + usuario.FechaCreacion + "',"
                                   + "ID_PERFIL = " + usuario.IdPerfil + ","
                                   + "ID_ESTD_CTA = " + usuario.IdEstadoCuenta + " "
                                   + "WHERE ID_USUARIO = " + usuario.IdUsuario + ";";
            this.con.EsSelect = false;
            this.con.conectar();
        }


        public Usuario buscarUsuario(String idUsuario)
        {
            Usuario usuario = new Usuario();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_USUARIO = " + idUsuario + ";";
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                usuario.IdUsuario = (int)dt.Rows[0]["ID_USUARIO"];
                usuario.Password = (String)dt.Rows[0]["PASSWORD"];
                usuario.FechaCreacion = (DateTime)dt.Rows[0]["FECHA_CREACION"];
                usuario.IdPerfil = (int)dt.Rows[0]["ID_PERFIL"];
                usuario.IdEstadoCuenta = (int)dt.Rows[0]["ID_ESTD_CTA"];
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
