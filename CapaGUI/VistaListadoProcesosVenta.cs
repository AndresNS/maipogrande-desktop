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
    public partial class VistaProcesosVenta : MetroFramework.Forms.MetroForm
    {
        public VistaProcesosVenta()
        {
            InitializeComponent();
        }

        private void VistaProcesosVenta_Load(object sender, EventArgs e)
        {
            // Cargar procesos de venta
            NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();
            DataSet listaProcesosVenta = negocioCabeceraPV.ListarProcesosVenta();

            this.dgvListaProcesosVenta.AutoGenerateColumns = true;
            this.dgvListaProcesosVenta.DataSource = listaProcesosVenta.Tables["CABECERA_PV"];
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            // Ver detalles de proceso de venta seleccionado
            int indiceFila = this.dgvListaProcesosVenta.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaProcesosVenta.Rows[indiceFila];

            VistaDetalleProcesoVenta vistaDetalleProcesoVenta = new VistaDetalleProcesoVenta(int.Parse(filaSeleccionada.Cells["ID_CABECERA_PV"].Value.ToString()));

            vistaDetalleProcesoVenta.ShowDialog();

        }
    }
}
