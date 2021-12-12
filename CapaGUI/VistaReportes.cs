using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDTO;


namespace CapaGUI
{
    public partial class VistaReportes : MetroFramework.Forms.MetroForm
    {
        public VistaReportes()
        {
            InitializeComponent();
        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                
                NegocioReportee negocioReporte = new NegocioReportee();

                DataSet listaReporte = negocioReporte.retornarVentas(this.txtFechaInicio.Value, this.txtFechatermino.Value);
                this.dgvReporte.AutoGenerateColumns = true;
                this.dgvReporte.DataSource = listaReporte.Tables["CABECERA_PV"];


             
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL LISTAR PRODUCTOS" + ex);
            }
        }
    }
}
