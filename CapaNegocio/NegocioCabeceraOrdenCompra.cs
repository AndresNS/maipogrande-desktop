using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioCabeceraOrdenCompra
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CABECERA_OC";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarOrdenesCompra()
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

        public CabeceraOrdenCompra buscarCabeceraProcesoVenta(int idCabeceraProcesoVenta)
        {
            CabeceraOrdenCompra cabeceraOrdenCompra = new CabeceraOrdenCompra();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_CABECERA_OC = " + idCabeceraProcesoVenta;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                cabeceraOrdenCompra.IdCabeceraOrdenCompra= (int)dt.Rows[0]["ID_CABECERA_OC"];
                cabeceraOrdenCompra.FechaEmision = (DateTime)dt.Rows[0]["FECHA_EMISION"];
                cabeceraOrdenCompra.RutCliente = (int)dt.Rows[0]["RUT_CLIENTE"];
            }
            catch (Exception ex)
            {
                CabeceraOrdenCompra auxCabeceraOrdenCompra = new CabeceraOrdenCompra();
                return auxCabeceraOrdenCompra;
            }

            return cabeceraOrdenCompra;
        }
    }
}
