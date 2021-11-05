using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioCategoria
    {


        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CATEGORIA";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:001CAT NAME:NEGOCIO CATEGORIA " + ex);
            }
           
        }
        public DataSet retornarCategorias()
        {
            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:002CAT NAME:NEGOCIO CATEGORIA " + ex);
            }

            return this.con.DbDataSet;
        }

        public void IngresarCategoria(Categoria categoria)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "NOMBRE_CATEGORIA" };
                OracleDbType[] tipos = { OracleDbType.Varchar2 };
                Object[] valores = { categoria.NombreCategoria };

                this.con.ejecutarProcedimiento("SP_INGRESAR_CATEGORIA", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:003CAT NAME:NEGOCIO CATEGORIA " + ex);
            }

        }

        public void eliminarCategoria(int idCategoria)
        {
            //this.configurarConexion();
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { idCategoria };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_CATEGORIA", parametros, tipos, valores);
            }
          
              catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:004CAT NAME:NEGOCIO CATEGORIA " + ex);
            }
        }

        public void actualizarCategoria(Categoria categoria)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID_CATEGORIA", "NOMBRE_CATEGORIA" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2 };
                Object[] valores = { categoria.IdCategoria, categoria.NombreCategoria };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CATEGORIA", parametros, tipos, valores);
            }
       
              catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CAT NAME:NEGOCIO CATEGORIA " + ex);
            }
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
                categoria.IdCategoria = (short)dt.Rows[0]["ID_CATEGORIA"];
                categoria.NombreCategoria = (String)dt.Rows[0]["NOMBRE_CATEGORIA"];
                
            }
            catch (Exception ex)
            {
                
                Categoria auxCategoria = new Categoria();
                return auxCategoria;

                MessageBox.Show("ERROR ID:006CAT NAME:NEGOCIO CATEGORIA " + ex);
            }

            return categoria;

        }

    }
}
