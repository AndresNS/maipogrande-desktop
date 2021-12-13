using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class VistaPagos : MetroFramework.Forms.MetroForm
    {
        public VistaPagos()
        {
            InitializeComponent();
        }

        private void VistaPagos_Load(object sender, EventArgs e)
        {
            NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();
            DataSet listaProcesosVenta = negocioCabeceraPV.ListarProcesosVenta();

            this.dgvListaProcesosVenta.AutoGenerateColumns = true;
            this.dgvListaProcesosVenta.DataSource = listaProcesosVenta.Tables["CABECERA_PV"];
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaProcesosVenta.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaProcesosVenta.Rows[indiceFila];
            int idProcesoVenta = int.Parse(filaSeleccionada.Cells["ID_CABECERA_PV"].Value.ToString());

            NegocioCabeceraProcesoVenta negocioCabeceraProcesoVenta = new NegocioCabeceraProcesoVenta();
            negocioCabeceraProcesoVenta.actualizarEstadoProcesoVenta(idProcesoVenta, 3); // Marcar como pagada

            MessageBox.Show("Se ha registrado el proceso de venta como PAGADO.");
        }
    }
}
