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
    public class NegocioProducto
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "Producto";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarProducto()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarProducto(Producto producto)
        {
            this.configurarConexion();
            String[] parametros = { "ID_CATEGORIA", "NOMBRE_PRODUCTO", "PRECIO", "ID_CALIDAD", "PORCENTAJE_MERMA" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Double };
            Object[] valores = { producto.IdCategoria, producto.NombreProducto, producto.Precio, producto.IdCalidad, producto.PorcentajeMerma };

            this.con.ejecutarProcedimiento("SP_INGRESAR_PRODUCTO", parametros, tipos, valores);
        }

        public void eliminarProducto(int idProducto)
        {
          
            this.configurarConexion();
            String[] parametros = { "ID" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { idProducto };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_PRODUCTO", parametros, tipos, valores);
        }

        public void actualizarProducto(Producto producto)
        {
            this.configurarConexion();
            String[] parametros = { "ID_PRODUCTO", "ID_CATEGORIA", "NOMBRE_PRODUCTO", "PRECIO", "ID_CALIDAD", "PORCENTAJE_MERMA" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Double };
            Object[] valores = { producto.IdProducto, producto.IdCategoria, producto.NombreProducto, producto.Precio, producto.IdCalidad, producto.PorcentajeMerma };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_PRODUCTO", parametros, tipos, valores);
        }



        public Producto buscarProducto(int idProducto)
        {
            Producto producto = new Producto();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_USUARIO = " + idProducto;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                producto.IdProducto = (int)dt.Rows[0]["ID_PRODUCTO"];
                producto.IdCategoria = (int)dt.Rows[0]["ID_CATEGORIA"];
                producto.NombreProducto = (String)dt.Rows[0]["NOMBRE_PRODUCTO"];
                producto.Precio = (int)dt.Rows[0]["PRECIO"];
                producto.IdCalidad = (int)dt.Rows[0]["ID_CALIDAD"];
                producto.PorcentajeMerma = (Double)dt.Rows[0]["PORCENTAJE_MERMA"];
            }
            catch (Exception ex)
            {
                Producto auxProducto = new Producto();
                return auxProducto;
            }

            return producto;

        }
    }
}
