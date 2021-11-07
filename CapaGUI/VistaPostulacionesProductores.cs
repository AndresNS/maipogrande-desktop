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
            //NegocioCabeceraSubastaTransporte negocioCabeceraSubasta = new NegocioCabeceraSubastaTransporte();
            //CabeceraSubastaTransporte subastaTransporte = negocioCabeceraSubasta.buscarSubastaTransporteDeProcesoVenta(this.IdProcesoVenta);

            //NegocioDetalleSubastaTransporte negocioDetalleSubastaTransporte = new NegocioDetalleSubastaTransporte();
            //DataSet listaSubastasTransporte = negocioDetalleSubastaTransporte.ListarDetallesSubasta(subastaTransporte.IdCabeceraSubasta);

            //this.dgvListaSubastasTransporte.AutoGenerateColumns = true;
            //this.dgvListaSubastasTransporte.DataSource = listaSubastasTransporte.Tables["DETALLE_SUBASTA"];

        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarTransporte_Click(object sender, EventArgs e)
        {

        }
    }
}
