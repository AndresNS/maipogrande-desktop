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
    public class NegocioEmpresaTransporte
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "EMPRESA_TRANSPORTE";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarEmpresasTranporte()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarEmpresaTransporte(EmpresaTransporte empTransporte)
        {
            this.configurarConexion();
            String[] parametros = { "NOMBRE_EMPRESA", "ID_USUARIO" };
            OracleDbType[] tipos = { OracleDbType.Varchar2, OracleDbType.Int32 };
            Object[] valores = { empTransporte.NombreEmpresa, empTransporte.IdUsuario};

            this.con.ejecutarProcedimiento("SP_INGRESAR_EMPRESA_TRANSP", parametros, tipos, valores);
        }

        public void eliminarEmpresaTransporte(int idEmpresa)
        {
            this.configurarConexion();
            String[] parametros = { "ID" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { idEmpresa };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_EMPRESA_TRANSPORTE", parametros, tipos, valores);
        }

        public void actualizarEmpresaTransporte(EmpresaTransporte empTransporte)
        {
            this.configurarConexion();
            String[] parametros = { "ID", "NOMBRE", "USUARIO" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Int32 };
            Object[] valores = { empTransporte.IdEmpresa, empTransporte.NombreEmpresa, empTransporte.IdUsuario };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_EMPRESA_TRANSP", parametros, tipos, valores);
        }


        public EmpresaTransporte buscarEmpresaTransporte(int idEmpresa)
        {
            EmpresaTransporte empTransporte = new EmpresaTransporte();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_EMPRESA = " + idEmpresa;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                empTransporte.IdEmpresa = (int)dt.Rows[0]["ID_EMPRESA"];
                empTransporte.NombreEmpresa = (String)dt.Rows[0]["NOMBRE_EMPRESA"];
                empTransporte.IdUsuario = (int)dt.Rows[0]["ID_USUARIO"];
            }
            catch (Exception ex)
            {
                EmpresaTransporte auxEmpTransporte = new EmpresaTransporte();
                return auxEmpTransporte;
            }

            return empTransporte;
        }
    }
}
