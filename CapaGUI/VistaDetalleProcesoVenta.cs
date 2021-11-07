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
    public partial class VistaDetalleProcesoVenta : MetroFramework.Forms.MetroForm
    {
        private int idProcesoVenta;

        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public VistaDetalleProcesoVenta(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void VistaDetalleProcesoVenta_Load(object sender, EventArgs e)
        {
            // cargar cabecera y detalles de proceso de venta
            NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();
            CabeceraProcesoVenta procesoVenta = negocioCabeceraPV.buscarCabeceraProcesoVenta(this.IdProcesoVenta);

            NegocioCliente negocioCliente = new NegocioCliente();
            Cliente cliente = negocioCliente.buscarCliente(procesoVenta.RutCliente);

            NegocioEstadoVenta negocioEstadoVenta = new NegocioEstadoVenta();
            EstadoVenta estadoVenta = negocioEstadoVenta.buscarEstado(procesoVenta.IdEstado);

            NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
            EmpresaTransporte empresaTransporte = negocioTransporte.buscarEmpresaTransporte(procesoVenta.IdEmpresaTransporte);

            this.txtIDProcesoVenta.Text = procesoVenta.IdCabeceraVenta.ToString();
            this.txtRutCliente.Text = cliente.Rut.ToString()+"-"+cliente.DvRut;
            this.txtRazonSocial.Text = cliente.RazonSocial;
            this.mdtFechaEmision.Value = procesoVenta.FechaEmision;
            this.txtEstado.Text = estadoVenta.Descripcion;
            this.txtEmpresaTransporte.Text = empresaTransporte.NombreEmpresa;
            this.txtObservaciones.Text = procesoVenta.Observaciones.ToString();

            NegocioDetalleProcesoVenta negocioDetallePV = new NegocioDetalleProcesoVenta();
            DataSet detalleProcesoVenta = negocioDetallePV.ListarDetallesProcesoVenta(procesoVenta.IdCabeceraVenta);

            this.dgvDetalleProcesoVenta.DataSource = detalleProcesoVenta.Tables["DETALLE_PV"];
        }

        private void btnVerPostulacionesTransporte_Click(object sender, EventArgs e)
        {
            VistaPostulacionesTransporte vistaPostulacionesTransporte = new VistaPostulacionesTransporte(this.IdProcesoVenta);
            vistaPostulacionesTransporte.ShowDialog();

        }

        private void btnVerPostulacionesProductores_Click(object sender, EventArgs e)
        {
            VistaPostulacionesProductores vistaPostulacionesProductores = new VistaPostulacionesProductores(this.IdProcesoVenta);
            vistaPostulacionesProductores.ShowDialog();
        }
    }
}
