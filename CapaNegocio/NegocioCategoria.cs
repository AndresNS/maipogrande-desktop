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
    public class NegocioCategoria
    {


        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "CATEGORIA";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarCategoria()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarCategoria(Categoria categoria)
        {
            this.configurarConexion();
            String[] parametros = { "NOMBRE_CATEGORIA" };
            OracleDbType[] tipos= { OracleDbType.Int32 };
            Object[] valores = { categoria.NombreCategoria};

            this.con.ejecutarProcedimiento("SP_INGRESAR_CATEGORIA", parametros, tipos, valores);
        }

        public void eliminarCategoria(int idCategoria)
        {
            this.configurarConexion();

            this.configurarConexion();
            String[] parametros = { "ID" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { idCategoria };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_CATEGORIA", parametros, tipos, valores);
        }

        public void actualizarCategoria(Categoria categoria)
        {
            this.configurarConexion();
            String[] parametros = { "ID_CATEGORIA", "NOMBRE_CATEGORIA"};
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2};
            Object[] valores = { categoria.IdCategoria, categoria.NombreCategoria };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CATEGORIA", parametros, tipos, valores);
        }


        public Categoria buscarCategoria(int idCategoria)
        {
            Categoria categoria = new Categoria();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CATEGORIA = " + idCategoria;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                categoria.IdCategoria = (int)dt.Rows[0]["ID_CATEGORIA"];
                categoria.NombreCategoria = (String)dt.Rows[0]["NOMBRE_CATEGORIA"];
                
            }
            catch (Exception ex)
            {
                Categoria auxCategoria = new Categoria();
                return auxCategoria;
            }

            return categoria;

        }

    }
}
