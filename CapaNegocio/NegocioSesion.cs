using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
     public class NegocioSesion
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();

            this.con.NombreBaseDeDatos = "maipogrande";
            this.con.NombreTabla = "USUARIO";
            this.con.CadenaConexion = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
        }

        public Boolean IngresoSistema(Sesion ingreso)
        {

            try
            {
                this.configurarConexion();
                this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla + " WHERE "
                                     + " NOMBRE_USUARIO = '" + ingreso.Nombre_usuario + "' AND"
                                     + " PASSWORD = '" + ingreso.Password + "'"
                                     + " AND ID_PERFIL = 1 AND ID_ESTD_CTA = 1";
                this.con.EsSelect = true;
                this.con.conectar();

                return this.con.DbDataSet.Tables[this.con.NombreTabla].Rows.Count == 1;

                //SELECT* FROM USUARIO WHERE NOMBRE_USUARIO = 'sysadmin' AND PASSWORD = 'sysadmin'
                //AND ID_PERFIL = 1 AND ID_ESTD_CTA = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al ingresar CODIGO: Login001 "  +ex);
                return false;
            }

        }


    }
}
