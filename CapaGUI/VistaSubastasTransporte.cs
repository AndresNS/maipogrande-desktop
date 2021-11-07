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
    public partial class VistaSubastasTransporte : MetroFramework.Forms.MetroForm
    {
        private int idProcesoVenta;

        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public VistaSubastasTransporte(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void VistaPostulacionesTransporte_Load(object sender, EventArgs e)
        {
            // Cargar subastas de transporte 
            NegocioCabeceraSubastaTransporte negocioCabeceraSubastaTransporte = new NegocioCabeceraSubastaTransporte();
            DataSet listaSubastasTransporte = negocioCabeceraSubastaTransporte.ListarSubastasTransporte(this.IdProcesoVenta);

            this.dgvListaSubastasTransporte.AutoGenerateColumns = true;
            this.dgvListaSubastasTransporte.DataSource = listaSubastasTransporte.Tables["CABECERA_SUBASTA"];
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            // Ver detalles de subasta de transporte seleccionado
            int indiceFila = this.dgvListaSubastasTransporte.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaSubastasTransporte.Rows[indiceFila];

            VistaDetalleSubastaTransporte vistaDetalleSubastaTransporte = new VistaDetalleSubastaTransporte(int.Parse(filaSeleccionada.Cells["ID_CABECERA_SUBASTA"].Value.ToString()));

            vistaDetalleSubastaTransporte.ShowDialog();
        }

        private void btnSeleccionarTransporte_Click(object sender, EventArgs e)
        {

        }


    }
}
