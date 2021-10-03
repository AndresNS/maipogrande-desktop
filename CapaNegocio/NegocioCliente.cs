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
    public class NegocioCliente
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipo_grande";
            this.con.NombreTabla = "CLIENTE";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }
        public DataSet retornarClientes()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
            this.con.EsSelect = true;
            this.con.conectar();

            return this.con.DbDataSet;
        }

        public void IngresarCliente(Cliente cliente)
        {
            this.configurarConexion();
            String[] parametros = { "CLIENTE_RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };
            Object[] valores = { cliente.Rut, cliente.DvRut, cliente.RazonSocial, cliente.Direccion, cliente.Giro, cliente.IdComuna, cliente.IdUsuario, cliente.IdTipo };

            this.con.ejecutarProcedimiento("SP_INGRESAR_CLIENTE", parametros, tipos, valores);
        }

        public void eliminarCliente(int rut)
        {
            this.configurarConexion();

            this.configurarConexion();
            String[] parametros = { "RUT" };
            OracleDbType[] tipos = { OracleDbType.Int32 };
            Object[] valores = { rut };

            this.con.ejecutarProcedimiento("SP_ELIMINAR_CLIENTE", parametros, tipos, valores);
        }

        public void actualizarCliente(Cliente cliente)
        {
            this.configurarConexion();
            String[] parametros = { "CLIENTE_RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
            OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Date, OracleDbType.Int32, OracleDbType.Int32 };
            Object[] valores = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };

            this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CLIENTE", parametros, tipos, valores);
        }


        public Cliente buscarCliente(int idCliente)
        {
            Cliente cliente = new Cliente();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CLIENTE = " + idCliente;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                cliente.Rut = (int)dt.Rows[0]["RUT"];
                cliente.DvRut = (String)dt.Rows[0]["DV_RUT"];
                cliente.RazonSocial = (String)dt.Rows[0]["RAZON_SOCIAL"];
                cliente.Direccion = (String)dt.Rows[0]["DIRECCION"];
                cliente.Giro = (String)dt.Rows[0]["GIRO"];
                cliente.IdComuna = (short)dt.Rows[0]["ID_COMUNA"];
                cliente.IdUsuario = (int)dt.Rows[0]["ID_USUARIO"];
                cliente.IdTipo = (short)dt.Rows[0]["ID_TIPO"];
            }
            catch (Exception ex)
            {
                Cliente auxCliente = new Cliente();
                return auxCliente;
            }

            return cliente;

        }

    }
}
