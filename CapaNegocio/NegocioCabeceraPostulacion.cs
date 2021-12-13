using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioCabeceraPostulacion
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CABECERA_POSTULACION";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarPostulaciones(int idProcesoVenta)
        {
            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla +
                    " WHERE CABECERA_PV = " + idProcesoVenta;
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

        public CabeceraPostulacion buscarCabeceraPostulacion(int idCabeceraPostulacion)
        {
            CabeceraPostulacion cabeceraPostulacion = new CabeceraPostulacion();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CABECERA_POSTULACION = " + idCabeceraPostulacion;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                cabeceraPostulacion.IdCabeceraPostulacion = (int)dt.Rows[0]["ID_CABECERA_POSTULACION"];
                cabeceraPostulacion.FechaEmision = (DateTime)dt.Rows[0]["FECHA_EMISION"];
                cabeceraPostulacion.RutProductor = (int)dt.Rows[0]["RUT_PRODUCTOR"];
                cabeceraPostulacion.IdCabeceraProcesoVenta = (int)dt.Rows[0]["CABECERA_PV"];
                cabeceraPostulacion.IdEstadoPostulacion = (short)dt.Rows[0]["ID_ESTADO_POSTULACION"];
            }
            catch (Exception ex)
            {
                CabeceraPostulacion auxCabeceraPostulacion = new CabeceraPostulacion();
                return auxCabeceraPostulacion;
            }

            return cabeceraPostulacion;
        }

        public void actualizarEstadoPostulacion(int idCabeceraPostulacion, int idEstadoPostulacion)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "UPDATE " + this.con.NombreTabla +
                                 " SET ID_ESTADO_POSTULACION = " + idEstadoPostulacion +
                                 " WHERE ID_CABECERA_POSTULACION = " + idCabeceraPostulacion;
            this.con.EsSelect = false;
            this.con.conectar();
        }
    }
}
