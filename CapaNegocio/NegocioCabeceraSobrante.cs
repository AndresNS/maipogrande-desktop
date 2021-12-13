using CapaConexion;
using CapaDTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioCabeceraSobrante
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CABECERA_SOBRANTE";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO CONTRATO " + ex);
            }
        }

        public void ingresarCabeceraSobrante(CabeceraSobrante cabeceraSobrante)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID_CABECERA_PV"};
                OracleDbType[] tipos = {OracleDbType.Int32 };
                Object[] valores = { cabeceraSobrante.IdCabeceraProcesoVenta,};

                this.con.ejecutarProcedimiento("SP_INGRESAR_CAB_SOBRANTE", parametros, tipos, valores);

            }

            catch (Exception exingresocliente)
            {
                MessageBox.Show("ERROR ID:003CLI NAME:NEGOCIO CLIENTE" + exingresocliente);
            }

        }

        public CabeceraSobrante buscarUltimaInsercion()
        {
            CabeceraSobrante cabeceraSobrante = new CabeceraSobrante();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CAB_SOBRANTE = (SELECT MAX(ID_CAB_SOBRANTE) FROM " + this.con.NombreTabla + ")";
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                cabeceraSobrante.IdCabeceraSobrante = (short)dt.Rows[0]["ID_CAB_SOBRANTE"];
                cabeceraSobrante.IdCabeceraProcesoVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
            }
            catch (Exception ex)
            {
                CabeceraSobrante auxCabeceraSobrante = new CabeceraSobrante();
                return auxCabeceraSobrante;
            }

            return cabeceraSobrante;
        }

        public CabeceraSobrante buscarCabeceraSobrante(int idCabeceraSobrante)
        {
            CabeceraSobrante cabeceraSobrante = new CabeceraSobrante();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CAB_SOBRANTE = " + idCabeceraSobrante;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                cabeceraSobrante.IdCabeceraSobrante = (short)dt.Rows[0]["ID_CAB_SOBRANTE"];
                cabeceraSobrante.IdCabeceraProcesoVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:006CLI NAME:NEGOCIO CLIENTE " + ex);
            }

            return cabeceraSobrante;

        }

    }
}
