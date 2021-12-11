using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaConexion;
using System.Windows.Forms;
using System.Data;

namespace CapaNegocio
{
    class NegocioTipoCliente
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "TIPO_CLIENTE";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO TIPO CLIENTE" + ex);
            }
        }

        public TipoCliente buscarTipoCliente(int idTipoCliente)
        {
            TipoCliente tipoCliente= new TipoCliente();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_TIPO = " + idTipoCliente;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                tipoCliente.IdTipoCliente= (short)dt.Rows[0]["ID_TIPO"];
                tipoCliente.DescTipoCliente = (String)dt.Rows[0]["DESC_TIPO"];
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:006CON NAME:NEGOCIO TIPO CLIENTE " + ex);
            }

            return tipoCliente;
        }
    }
}

