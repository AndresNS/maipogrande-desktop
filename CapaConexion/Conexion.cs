using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace CapaConexion
{
    public class Conexion
    {

        private String nombreBaseDeDatos;

        public String NombreBaseDeDatos
        {
            get { return nombreBaseDeDatos; }
            set { nombreBaseDeDatos = value; }
        }

        private String nombreTabla;

        public String NombreTabla
        {
            get { return nombreTabla; }
            set { nombreTabla = value; }
        }

        private String cadenaConexion;

        public String CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = value; }
        }

        private String cadenaSQL;

        public String CadenaSQL
        {
            get { return cadenaSQL; }
            set { cadenaSQL = value; }
        }

        private Boolean esSelect;

        public Boolean EsSelect
        {
            get { return esSelect; }
            set { esSelect = value; }
        }


        private DataSet dbDataSet;

        public DataSet DbDataSet
        {
            get { return dbDataSet; }
            set { dbDataSet = value; }
        }


        public void conectar()
        {
            //Se validan las variables de   
            if (this.NombreBaseDeDatos.Length == 0)
            {
                MessageBox.Show("Falta nombre base de datos ", "Mensaje Sistema");
                return;
            }

            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Falta nombre tabla ", "Mensaje Sistema");
                return;
            }

            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Falta cadena Conexion", "Mensaje Sistema");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Falta cadena SQL ", "Mensaje Sistema");
                return;
            }

            using (OracleConnection con = new OracleConnection(this.CadenaConexion))
            {
                if (this.EsSelect)
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Conectado a la base de datos");
                        Console.WriteLine();

                        OracleDataAdapter dbAdapter = new OracleDataAdapter
                        {
                            SelectCommand = new OracleCommand(this.CadenaSQL, con)
                        };

                        this.DbDataSet = new DataSet();
                        dbAdapter.Fill(this.DbDataSet, this.NombreTabla);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message, "Mensaje Sistema");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        con.Open();
                        OracleCommand command = new OracleCommand(this.CadenaSQL, con);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en SQL " + ex.Message, "mensaje Sistema");
                        return;
                    }
                }
            }
         }
    }
}
