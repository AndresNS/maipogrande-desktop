using CapaConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioCabeceraProcesoVenta
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CABECERA_PV";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarProcesosVenta()
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
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
            }

            return this.con.DbDataSet;
        }

        public CabeceraProcesoVenta buscarCabeceraProcesoVenta(int idCabeceraProcesoVenta)
        {
            CabeceraProcesoVenta procesoVenta = new CabeceraProcesoVenta();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                procesoVenta.IdCabeceraVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
                procesoVenta.IdEmpresaTransporte = (int)dt.Rows[0]["EMPRESA_TRANS"];
                procesoVenta.FechaEmision = (DateTime)dt.Rows[0]["FECHA_EMISION"];
                procesoVenta.Observaciones = (String)dt.Rows[0]["OBS_PV"];
                procesoVenta.IdEstado = (short)dt.Rows[0]["ESTADO_PV"];
                procesoVenta.RutCliente = (int)dt.Rows[0]["RUT_CLIENTE"];
            }
            catch (Exception ex)
            {
                CabeceraProcesoVenta auxCabeceraProcesoVenta = new CabeceraProcesoVenta();
                return auxCabeceraProcesoVenta;
            }

            return procesoVenta;
        }

        public void asignarTransporte(int idCabeceraProcesoVenta, int idTransporte)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "UPDATE " + this.con.NombreTabla +
                                 " SET EMPRESA_TRANS = " + idTransporte +
                                 " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = false;
            this.con.conectar();
        }

        public void actualizarEstadoProcesoVenta(int idCabeceraProcesoVenta, int idEstado)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "UPDATE " + this.con.NombreTabla +
                                 " SET ESTADO_PV = " + idEstado +
                                 " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = false;
            this.con.conectar();
        }

    }
}
