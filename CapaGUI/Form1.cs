using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using Oracle.ManagedDataAccess.Client;

namespace CapaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion conec1 = new Conexion();
            conec1.NombreBaseDeDatos = "hr";
            conec1.NombreTabla = "COUNTRIES";
            conec1.CadenaConexion = "Data Source=localhost:1521/xe;User Id=hr;Password=hr;";
            conec1.CadenaSQL = "SELECT COUNTRY_NAME from " + conec1.NombreTabla;
            conec1.EsSelect = true;

            conec1.conectar();

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = conec1.DbDataSet.Tables[0];

        }


    }
}
