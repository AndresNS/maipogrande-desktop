using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioPerfil
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new Conexion();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.NombreTabla = "PERFIL";
                this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO TIPO CLIENTE" + ex);
            }
        }

        public DataSet retornarPerfiles()
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
                MessageBox.Show("ERROR ID:002CAT NAME:NEGOCIO PERFIL" + ex);
            }

            return this.con.DbDataSet;
        }

        public Perfil buscarPerfil(int idPerfil)
        {
            Perfil perfil = new Perfil();
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " "
                                   + "WHERE ID_PERFIL= " + idPerfil;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            try
            {
                perfil.IdPerfil= (short)dt.Rows[0]["ID_PERFIL"];
                perfil.DescPerfil= (String)dt.Rows[0]["DESC_PERFIL"];
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:006CON NAME:NEGOCIO PERFIL " + ex);
            }

            return perfil;
        }
    }
}
