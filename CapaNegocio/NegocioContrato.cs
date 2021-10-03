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
    public class NegocioContrato
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "CONTRATO";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarContratos()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarContrato(Contrato contrato)
        {
            this.configurarConexion();
            String[] parametros = { "FECHA_INICIO", "FECHA_TERMINO", "RUT_PRODUCTOR" };
            OracleDbType[] tipos = { OracleDbType.Date, OracleDbType.Date, OracleDbType.Int32 };
            Object[] valores = { contrato.FechaInicio, contrato.FechaTermino, contrato.RutProductor };

            this.con.ejecutarProcedimiento("SP_INGRESAR_CONTRATO", parametros, tipos, valores);
        }

        public void eliminarContrato(int idContrato)
        {
            this.configurarConexion();
            String[] parametros = { "ID" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { idContrato };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_CONTRATO", parametros, tipos, valores);
        }

        public void actualizarContrato(Contrato contrato)
        {
            this.configurarConexion();
            String[] parametros = { "ID", "F_INICIO", "F_TERMINO", "PRODUCTOR" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Date, OracleDbType.Date, OracleDbType.Int32 };
            Object[] valores = { contrato.IdContrato, contrato.FechaInicio, contrato.FechaTermino, contrato.RutProductor };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CONTRATO", parametros, tipos, valores);
        }


        public Contrato buscarContrato(int idContrato)
        {
            Contrato contrato = new Contrato();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CONTRATO = " + idContrato;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                contrato.IdContrato = (int)dt.Rows[0]["ID_CONTRATO"];
                contrato.FechaInicio = (DateTime)dt.Rows[0]["FECHA_INICIO"];
                contrato.FechaTermino = (DateTime)dt.Rows[0]["FECHA_TERMINO"];
                contrato.RutProductor = (int)dt.Rows[0]["RUT_PRODUCTOR"];
            }
            catch (Exception ex)
            {
                Contrato auxContrato = new Contrato();
                return auxContrato;
            }

            return contrato;
        }
    }
}
