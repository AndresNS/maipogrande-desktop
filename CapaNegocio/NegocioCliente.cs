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
    public class NegocioCliente
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CLIENTE";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR ID:001CLI NAME:NEGOCIO CLIENTE " + ex);
            }
            
        }
        public DataSet retornarClientes()
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
                MessageBox.Show("ERROR ID:002CLI NAME:NEGOCIO CLIENTE " + ex);
            }


            return this.con.DbDataSet;
        }

        public void IngresarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { cliente.Rut, cliente.DvRut, cliente.RazonSocial, cliente.Direccion, cliente.Giro, cliente.IdComuna, cliente.IdUsuario, cliente.IdTipo };

                this.con.ejecutarProcedimiento("SP_INGRESAR_CLIENTE", parametros, tipos, valores);

            }

            catch (Exception exingresocliente)
            {
                MessageBox.Show("ERROR ID:003CLI NAME:NEGOCIO CLIENTE" + exingresocliente);
            }

        }

        public void eliminarCliente(int rut)
        {
            try
            {
                this.configurarConexion();

                this.configurarConexion();
                String[] parametros = { "RUT" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { rut };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_CLIENTE", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:004CLI NAME:NEGOCIO CLIENTE " + ex);
            }

        }

        public void actualizarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { cliente.Rut, cliente.DvRut, cliente.RazonSocial, cliente.Direccion, cliente.Giro, cliente.IdComuna, cliente.IdUsuario, cliente.IdTipo };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CLIENTE", parametros, tipos, valores);
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CLI NAME:NEGOCIO CLIENTE " + ex);
            }
        }


        public Cliente buscarCliente(int rutcliente)
        {
            Cliente cliente = new Cliente();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE RUT = " + rutcliente;
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
                MessageBox.Show("ERROR ID:006CLI NAME:NEGOCIO CLIENTE " + ex);
            }

            return cliente;

        }

    }
}
