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
    public class NegocioProductor
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "PRODUCTOR";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:001CTOR NAME:NEGOCIO PRODUCTOR " + ex);
            }
        }
        public DataSet retornarProductores()
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

                MessageBox.Show("ERROR ID:002CTOR NAME:NEGOCIO PRODUCTOR  " + ex);
            }

            return this.con.DbDataSet;
        }

        public Productor buscarPorIdUsr(int idUsr)
        {
            Productor productor = new Productor();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_USUARIO = " + idUsr;
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                productor.Rut = (int)dt.Rows[0]["RUT"];
                productor.DigitoVerificador = (String)dt.Rows[0]["DV_RUT"];
                productor.RazonSocial = (String)dt.Rows[0]["RAZON_SOCIAL"];
                productor.Direccion = (String)dt.Rows[0]["DIRECCION"];
                productor.Giro = (String)dt.Rows[0]["GIRO"];
                productor.IdComuna = (short)dt.Rows[0]["ID_COMUNA"];
                productor.IdUsuario = (int)dt.Rows[0]["ID_USUARIO"];
            }
            catch (Exception ex)
            {
                //Usuario auxUsuario = new Usuario();
                //return auxUsuario;
            }

            return productor;
        }


        public void IngresarProductor(Productor productor)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { productor.Rut, productor.DigitoVerificador, productor.RazonSocial, productor.Direccion, productor.Giro, productor.IdComuna, productor.IdUsuario };

                this.con.ejecutarProcedimiento("SP_INGRESAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception exingresoproductor)
            {
                MessageBox.Show("ERROR ID:003CTOR NAME:NEGOCIO PRODUCTOR  " + exingresoproductor);
            }
        
        }

        public void eliminarProductor(int rutProductor)
        {
            try
            {


                this.configurarConexion();
                String[] parametros = { "RUTP" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { rutProductor };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:004CTOR NAME:NEGOCIO PRODUCTOR  " + ex);
            }

        }

        public void actualizarProductor(Productor productor)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUTP", "DV_RUTP", "RAZON_SOCIALP", "DIRECCIONP", "GIROP", "ID_COMUNAP", "ID_USUARIOP" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { productor.Rut, productor.DigitoVerificador, productor.RazonSocial, productor.Direccion, productor.Giro, productor.IdComuna, productor.IdUsuario };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception exactualizarProductor)
            {
                MessageBox.Show("ERROR ID:005CTOR NAME:NEGOCIO PRODUCTOR " + exactualizarProductor);

            }
      
        }


        public Productor buscarProductor(int rutProductor)
        {
            Productor productor = new Productor();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE RUT = " + rutProductor;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                productor.Rut = (int)dt.Rows[0]["RUT"];
                productor.DigitoVerificador = (String)dt.Rows[0]["DV_RUT"];
                productor.RazonSocial = (String)dt.Rows[0]["RAZON_SOCIAL"];
                productor.Direccion = (String)dt.Rows[0]["DIRECCION"];
                productor.Giro = (String)dt.Rows[0]["GIRO"];
                productor.IdComuna = (short)dt.Rows[0]["ID_COMUNA"]; //esya en short lo cambio a int
                productor.IdUsuario = (short)dt.Rows[0]["ID_USUARIO"];
            }
            catch (Exception ex)
            {
                //Productor auxProductor = new Productor();
                //return auxProductor;
            }

            return productor;
        }
    }
}
