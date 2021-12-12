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
    public partial class VistaPostulacionesProductores : MetroFramework.Forms.MetroForm
    {
        private int idProcesoVenta;

        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public VistaPostulacionesProductores(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void VistaPostulacionesProductores_Load(object sender, EventArgs e)
        {
            // Cargar Postulaciones de Productores
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            DataSet listaSubastasTransporte = negocioCabeceraPostulacion.ListarPostulaciones(this.IdProcesoVenta);

            this.dgvListaPostulacionesProductores.AutoGenerateColumns = true;
            this.dgvListaPostulacionesProductores.DataSource = listaSubastasTransporte.Tables["CABECERA_POSTULACION"];
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaPostulacionesProductores.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaPostulacionesProductores.Rows[indiceFila];

            VistaDetallePostulacionProductor vistaDetallePostulacionProductor = new VistaDetallePostulacionProductor(int.Parse(filaSeleccionada.Cells["ID_CABECERA_POSTULACION"].Value.ToString()));
            vistaDetallePostulacionProductor.ShowDialog();
        }

    }
}
