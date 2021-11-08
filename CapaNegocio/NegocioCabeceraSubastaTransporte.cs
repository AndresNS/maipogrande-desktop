using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaDTO;
using CapaConexion;

namespace CapaNegocio
{
    public class NegocioCabeceraSubastaTransporte
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CABECERA_SUBASTA";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarSubastasTransporte(int idProcesoVenta)
        {
            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla +
                    " WHERE ID_CABECERA_PV = " + idProcesoVenta;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
            }

            return this.con.DbDataSet;
        }

        public CabeceraSubastaTransporte buscarCabeceraSubastaTransporte(int idCabeceraSubastaTransporte)
        {
            CabeceraSubastaTransporte subastaTransporte = new CabeceraSubastaTransporte();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CABECERA_SUBASTA = " + idCabeceraSubastaTransporte;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                subastaTransporte.IdCabeceraSubasta = (int)dt.Rows[0]["ID_CABECERA_SUBASTA"];
                subastaTransporte.FechaLimiteEntrega = (DateTime)dt.Rows[0]["FECHA_LIMITE_ENTREGA"];
                subastaTransporte.IdComuna= (short)dt.Rows[0]["ID_COMUNA"];
                subastaTransporte.IdCabeceraProcesoVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
                subastaTransporte.IdEstadoSubasta = (int)dt.Rows[0]["ID_ESTADO_SUBASTA"];
            }
            catch (Exception ex)
            {
                CabeceraSubastaTransporte auxCabeceraSubastaTransporte = new CabeceraSubastaTransporte();
                return auxCabeceraSubastaTransporte;
            }

            return subastaTransporte;
        }

        public CabeceraSubastaTransporte buscarSubastaTransporteDeProcesoVenta(int idProcesoVenta)
        {
            CabeceraSubastaTransporte subastaTransporte = new CabeceraSubastaTransporte();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CABECERA_PV = " + idProcesoVenta;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                subastaTransporte.IdCabeceraSubasta = (int)dt.Rows[0]["ID_CABECERA_SUBASTA"];
                subastaTransporte.FechaLimiteEntrega = (DateTime)dt.Rows[0]["FECHA_LIMITE_ENTREGA"];
                subastaTransporte.IdComuna = (short)dt.Rows[0]["ID_COMUNA"];
                subastaTransporte.IdCabeceraProcesoVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
                subastaTransporte.IdEstadoSubasta = (int)dt.Rows[0]["ID_ESTADO_SUBASTA"];
            }
            catch (Exception ex)
            {
                CabeceraSubastaTransporte auxCabeceraSubastaTransporte = new CabeceraSubastaTransporte();
                return auxCabeceraSubastaTransporte;
            }

            return subastaTransporte;
        }

        public void cerrarSubasta(int idCabeceraProcesoVenta)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "UPDATE " + this.con.NombreTabla +
                                 " SET ID_ESTADO_SUBASTA = 2" +
                                 " WHERE ID_CABECERA_SUBASTA = " + idCabeceraProcesoVenta;
            this.con.EsSelect = false;
            this.con.conectar();
        }
    }
}
