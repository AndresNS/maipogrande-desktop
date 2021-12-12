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
    public class NegocioReportee
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

                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet retornarVentas(DateTime fechaInicio, DateTime fechaTermino)
        {
            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " WHERE FECHA_EMISION BETWEEN TO_DATE('" + fechaInicio + "', 'DD/MM/YYYY HH24:MI:SS') AND TO_DATE('" + fechaTermino + "', 'DD/MM/YYYY HH24:MI:SS')";
                this.con.EsSelect = true;
                this.con.conectar();
                //SELECT* FROM CABECERA_PV WHERE FECHA_EMISION BETWEEN TO_DATE('12/12/2021 14:46:50', 'DD/MM/YYYY HH24:MI:SS') AND TO_DATE('12/12/2021 14:46:50', 'DD/MM/YYYY HH24:MI:SS');
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001REP NAME:NEGOCIO REPORTE " + ex);
            }

            return this.con.DbDataSet;
        }

    }
}
