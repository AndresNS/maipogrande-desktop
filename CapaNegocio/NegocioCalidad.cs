using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaConexion;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioCalidad
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "CALIDAD";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception exconfiguracionconexion)
            {
                MessageBox.Show("ERROR ID:01CAL NAME:NEGOCIO CALIDAD " +exconfiguracionconexion);
            }
            
        }
        public DataSet retornarCalidades()
        {
            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception exretornarcalidad)
            {
                MessageBox.Show("ERROR ID:02CAL NAME:NEGOCIO CALIDAD " + exretornarcalidad);
            }

            return this.con.DbDataSet;
        }
    }
}
