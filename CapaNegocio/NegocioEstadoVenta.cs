using CapaConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class NegocioEstadoVenta
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "ESTADO_VENTA";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO CONTRATO " + ex);
            }
        }

        public EstadoVenta buscarEstado(int idEstado)
        {
            EstadoVenta estadoVenta = new EstadoVenta();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_ESTADO_PV = " + idEstado;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                estadoVenta.IdEstadoVenta = (short)dt.Rows[0]["ID_ESTADO_PV"];
                estadoVenta.Descripcion = (String)dt.Rows[0]["DESC_ESTADO"];
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:006CON NAME:NEGOCIO CONTRATO " + ex);
            }

            return estadoVenta;
        }
    }
}
